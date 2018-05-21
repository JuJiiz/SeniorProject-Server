using Accord.Video.FFMPEG;
using System.Drawing;
using System;
using Accord.Math;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;

namespace SeniorProject
{
    public partial class TrainForm : Form
    {
        private String InputPath = "NoPath";
        private String OutputPath = AppDomain.CurrentDomain.BaseDirectory + "Matlab\\trainResource.txt";
        private String strClass = "NoClass";

        BackgroundWorker bw = new BackgroundWorker();

        public TrainForm()
        {
            InitializeComponent();

            rbClass1.CheckedChanged += new EventHandler(radioButtons_CheckedChanged_on);
            rbClass2.CheckedChanged += new EventHandler(radioButtons_CheckedChanged_on);
            rbClass3.CheckedChanged += new EventHandler(radioButtons_CheckedChanged_on);
            rbClass4.CheckedChanged += new EventHandler(radioButtons_CheckedChanged_on);
            //rbClass5.CheckedChanged += new EventHandler(radioButtons_CheckedChanged_off);
            //rbClass6.CheckedChanged += new EventHandler(radioButtons_CheckedChanged_off);

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
                btnVideoBrowse.Enabled = false;
                bw.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Please Select \"Video Input\" and \"Class Value\".", "Train");
            }

        }

        //Uncheck off-road
        private void radioButtons_CheckedChanged_on(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            
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
                else if (rbClass4.Checked)
                {
                    strClass = "4.000000";
                }
            
        }
        
        private void process_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(1);

            VideoFileReader read = new VideoFileReader();
            read.Open(InputPath);

            double[,] genHog = HogTrain.hog(read);

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
            MatlabTrain.train(hiddenNeu, DataLength, 20);

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
            btnVideoBrowse.Enabled = true;
            MessageBox.Show("Successfully.", "Train");
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
