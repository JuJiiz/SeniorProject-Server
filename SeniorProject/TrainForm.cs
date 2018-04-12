using Accord.Video.FFMPEG;
using System.Drawing;
using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using Accord.Math;
using Accord.Imaging;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.ComponentModel;
using System.Threading;

namespace SeniorProject
{
    public partial class TrainForm : Form
    {
        private String InputPath = "NoPath";
        private String OutputPath = AppDomain.CurrentDomain.BaseDirectory + "trainResource.txt";
        private String strClass = "NoClass";

        BackgroundWorker bw = new BackgroundWorker();

        public TrainForm()
        {
            InitializeComponent();

            rbClass1.CheckedChanged += new EventHandler(radioButtons_CheckedChanged_on);
            rbClass2.CheckedChanged += new EventHandler(radioButtons_CheckedChanged_on);
            rbClass3.CheckedChanged += new EventHandler(radioButtons_CheckedChanged_on);
            rbClass4.CheckedChanged += new EventHandler(radioButtons_CheckedChanged_off);
            rbClass5.CheckedChanged += new EventHandler(radioButtons_CheckedChanged_off);
            rbClass6.CheckedChanged += new EventHandler(radioButtons_CheckedChanged_off);

            bw.WorkerReportsProgress = true;
            bw.DoWork += new DoWorkEventHandler(process_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(process_Change);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(process_Completed);
        }

        //Input Video Button
        private void browse_click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.lbFileLocal.Text = open.FileName;
                InputPath = open.FileName;
            }
        }

        //Execute Button
        private void run_click(object sender, EventArgs e)
        {
            if (!InputPath.Equals("NoPath") && !strClass.Equals("NoClass"))
            {
                btnRun.Enabled = false;
                bw.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Please Select \"Video Input\" and \"Class Value\".", "Train");
            }

        }

        private double[,] genHOG(VideoFileReader vdoRead)
        {
            Grayscale grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
            CannyEdgeDetector canny = new CannyEdgeDetector(0, 5);
            double[,] hogArray = new double[vdoRead.FrameCount - 1, 288];

            for (int i = 0; i < vdoRead.FrameCount - 1; i++)
            {
                Bitmap image = vdoRead.ReadVideoFrame(i);
                Bitmap resize = new Bitmap(image, 400, 300);
                Bitmap imgGray = grayscale.Apply(resize);
                Bitmap imgCanny = canny.Apply(imgGray);

                HistogramsOfOrientedGradients hog = new HistogramsOfOrientedGradients(9, 2, 16);
                Bitmap resizeHOG = new Bitmap(imgCanny, 64, 128);
                List<double[]> resultHOG = hog.ProcessImage(resizeHOG);
                double[][] valueHog = new double[8][];
                resultHOG.CopyTo(valueHog);
                int count = 0;
                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 36; k++)
                    {
                        if (count < 288)
                        {
                            hogArray[i, count] = valueHog[j][k];
                            count++;
                        }
                    }
                }

                //Clear value(Reduce RAM usage)
                image.Dispose();
                resize.Dispose();
                imgGray.Dispose();
                imgCanny.Dispose();
            }

            return hogArray;
        }

        //Execute Matlab OSELM Train
        private void matlab_execute(int nHiddenNeurons, int N0, int Block)
        {
            // Create the MATLAB instance 
            MLApp.MLApp matlab = new MLApp.MLApp();

            // Change to the directory where the function is located 
            matlab.Execute("cd " + AppDomain.CurrentDomain.BaseDirectory);

            // Define the output 
            object result = null;

            // Call the MATLAB function myfunc
            matlab.Feval("OSELM_train", 2, out result, "trainResource.txt", 1, nHiddenNeurons, "sig", N0, Block);

            // Display result 
            object[] res = result as object[];

            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);
            Console.ReadLine();
            matlab.Quit();
        }

        //Uncheck off-road
        private void radioButtons_CheckedChanged_on(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (rbClass1.Checked || rbClass2.Checked || rbClass3.Checked)
            {
                if (rbClass1.Checked)
                {
                    strClass = "1.000000";
                }
                else if (rbClass2.Checked)
                {
                    strClass = "2.000000";
                }
                else if (rbClass3.Checked)
                {
                    strClass = "3.000000";
                }

                rbClass4.Checked = false;
                rbClass5.Checked = false;
                rbClass6.Checked = false;
            }
        }

        //Uncheck on-road
        private void radioButtons_CheckedChanged_off(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (rbClass4.Checked || rbClass5.Checked || rbClass6.Checked)
            {
                if (rbClass4.Checked)
                {
                    strClass = "4.000000";
                }
                else if (rbClass5.Checked)
                {
                    strClass = "5.000000";
                }
                else if (rbClass6.Checked)
                {
                    strClass = "6.000000";
                }

                rbClass1.Checked = false;
                rbClass2.Checked = false;
                rbClass3.Checked = false;
            }
        }

        private void process_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(1);

            VideoFileReader read = new VideoFileReader();
            read.Open(InputPath);

            double[,] genHog = genHOG(read);

            StreamWriter file = new StreamWriter(OutputPath, true);
            for (int i = 0; i < read.FrameCount - 1; i++)
            {
                file.Write(strClass + "\t");
                for (int j = 0; j < 288; j++)
                {
                    file.Write(string.Format("{0:0.000000}", genHog[i, j]) + " ");
                }
                file.Write("\n");
            }
            file.Close();

            //int DataLength = genHog.Length / 288;
            int DataLength = File.ReadAllLines(OutputPath).Length;
            int hiddenNeu = DataLength / 2;

            Console.WriteLine(DataLength + " / " + hiddenNeu);

            worker.ReportProgress(2);
            matlab_execute(hiddenNeu, DataLength, 20);

            genHog.Clear();
        }

        private void process_Change(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage.ToString().Equals("1"))
            {
                this.lbStatus.Text = "Data Preparing...";
                this.lbStatus.ForeColor = Color.Red;
            }
            else if (e.ProgressPercentage.ToString().Equals("2"))
            {
                this.lbStatus.Text = "Train Processing...";
                this.lbStatus.ForeColor = Color.Red;
            }
            else
            {
                this.lbStatus.Text = "Processing...";
                this.lbStatus.ForeColor = Color.Red;
            }
        }

        private void process_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            this.lbStatus.Text = "Idle";
            this.lbStatus.ForeColor = Color.Black;
            btnRun.Enabled = true;
            MessageBox.Show("Successfully.", "Train");
        }
    }
}
