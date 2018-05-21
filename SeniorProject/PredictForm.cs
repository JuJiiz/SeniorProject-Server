using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using Accord.Video.FFMPEG;
using System.Drawing.Imaging;
using System.Drawing;
using AForge.Imaging.Filters;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using Accord.Math;
using System.Net;
using System.Net.Sockets;
using Accord.Imaging;
using System.IO;
using SimpleTCP;

namespace SeniorProject
{
    public partial class PredictForm : Form
    {
        private String InputPath = "NoPath";
        private String POPath = AppDomain.CurrentDomain.BaseDirectory + "Predict_output.txt";

        String[] dataReceived = new String[2];

        TcpListener listener;
        TcpClient client = new TcpClient();
        StreamReader STR;
        StreamWriter STW;
        String receive = "";
        Boolean ServerWork = false;

        long AllFrames = 0;
        int MFrames = 0;
        int LFrames = 0;
        int RFrames = 0;
        int OFrames = 0;
        int UnknowFrames = 0;

        String PredictResult = "";

        MLApp.MLApp matlab = new MLApp.MLApp();

        Grayscale grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
        CannyEdgeDetector canny = new CannyEdgeDetector(0, 5);

        BackgroundWorker bw = new BackgroundWorker();
        BackgroundWorker bwRead = new BackgroundWorker();
        BackgroundWorker bwWrite = new BackgroundWorker();

        public PredictForm()
        {
            InitializeComponent();

            //Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory + "Matlab\\");

            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(predict_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(predict_Change);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(predict_Completed);

            bwWrite.DoWork += new DoWorkEventHandler(serverWrite_DoWork);
        }

        private void browse_click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.lbFileLocal.Text = open.FileName;
                InputPath = open.FileName;
            }
        }

        public String matlabPredict(String hogClass, String hogValue)
        {
            matlab.Execute("cd " + AppDomain.CurrentDomain.BaseDirectory + "Matlab\\");
            object result = null;
            matlab.Feval("OSELM_predict", 2, out result, hogClass, hogValue);
            object[] res = result as object[];
            matlab.Quit();

            return Convert.ToString(res[0]);
        }

        private void run_click(object sender, EventArgs e)
        {
            if (!InputPath.Equals("NoPath"))
            {
                pbClose.Enabled = false;
                btnRun.Enabled = false;
                tbPredict.Clear();
                MFrames = 0;
                LFrames = 0;
                RFrames = 0;
                OFrames = 0;
                UnknowFrames = 0;
                bw.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Please Select \"Video Input\" ", "Predict");
            }
        }

        private void form_load(object sender, EventArgs e)
        {
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    lbIP.Text = address.ToString();
                    lbPort.Text = "8010";
                }
            }

            listener = new TcpListener(IPAddress.Parse(lbIP.Text), 8010);
        }

        private void StartServer_click(object sender, EventArgs e)
        {
            tbPredict.Clear();
            pbExam.Image = null;

            if (ServerWork == false)
            {
                bwRead = new BackgroundWorker();
                bwRead.DoWork += new DoWorkEventHandler(serverRead_DoWork);
                bwRead.WorkerSupportsCancellation = true;

                listener.Start();
                bwRead.RunWorkerAsync();
                lbStatus.Text = "Online";
                btnServer.Text = "Stop Server";
                lbStatus.ForeColor = Color.Green;
                ServerWork = true;

                btnVideoBrowse.Enabled = false;
                btnRun.Enabled = false;
                this.ControlBox = false;
            }
            else
            if (ServerWork == true)
            {
                listener.Stop();
                bwRead.CancelAsync();
                lbStatus.Text = "Offline";
                lbStatus.ForeColor = Color.Red;
                btnServer.Text = "Start Server";
                Console.WriteLine("Stop");
                ServerWork = false;

                btnVideoBrowse.Enabled = true;
                btnRun.Enabled = true;
                this.ControlBox = true;
            }
        }

        private void predict_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(0);

            VideoFileReader read = new VideoFileReader();
            read.Open(InputPath);

            double[,] hogArray = new double[read.FrameCount - 1, 288];
            AllFrames = read.FrameCount-1;

            for (int i = 0; i < read.FrameCount - 1; i++)
            {
                Bitmap image = read.ReadVideoFrame(i);
                Bitmap resize = new Bitmap(image, 400, 300);
                Bitmap imgGray = grayscale.Apply(resize);
                Bitmap imgCanny = canny.Apply(imgGray);

                pbExam.Image = image;

                HistogramsOfOrientedGradients hog = new HistogramsOfOrientedGradients(9, 2, 16);
                Bitmap resizeHOG = new Bitmap(imgCanny, 64, 128);
                List<double[]> resultHOG = hog.ProcessImage(resizeHOG);
                double[][] valueHog = new double[8][];
                resultHOG.CopyTo(valueHog);
                int count = 0;
                String hogValues = "";

                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 36; k++)
                    {
                        if (count < 288)
                        {
                            hogArray[i, count] = valueHog[j][k];
                            hogValues += string.Format("{0:0.000000}", hogArray[i, count]) + " ";
                            count++;
                        }
                    }
                }

                PredictResult = matlabPredict("0.000000", hogValues);

                worker.ReportProgress(100);

                //Clear value(Reduce RAM usage)
                image.Dispose();
                resize.Dispose();
                imgGray.Dispose();
                imgCanny.Dispose();
            }
        }

        private void predict_Change(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage.ToString().Equals("0"))
            {
                this.lbPredictStatus.Text = "Please wait...";
                this.lbPredictStatus.ForeColor = Color.Red;
            }

            if (e.ProgressPercentage.ToString().Equals("100"))
            {
                tbPredict.AppendText("Result: ");
                if (PredictResult.Equals("1"))
                {
                    tbPredict.AppendText("On lane (Middle)");
                    MFrames++;
                }
                else
                if (PredictResult.Equals("2"))
                {
                    tbPredict.AppendText("On lane (Left)");
                    LFrames++;
                }
                else
                if (PredictResult.Equals("3"))
                {
                    tbPredict.AppendText("On lane (Right)");
                    RFrames++;
                }
                else
                if (PredictResult.Equals("4"))
                {
                    tbPredict.AppendText("Head out");
                    OFrames++;
                }
                else
                {
                    tbPredict.AppendText("Unknow");
                    UnknowFrames++;
                }
                tbPredict.AppendText("\n");
            }

        }

        private void predict_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            this.lbPredictStatus.Text = "Idle";
            this.lbPredictStatus.ForeColor = Color.Black;
            btnRun.Enabled = true;
            pbClose.Enabled = true;
            MessageBox.Show("Successfully.\n" + "\nAll Frames: " + AllFrames + "\nMiddle: " + MFrames + "\nLeft: " + LFrames + "\nRight: " + RFrames + "\nOut: " + OFrames + "\nUnknow: " + UnknowFrames, "Predict");
        }

        private void form_Closed(object sender, FormClosedEventArgs e)
        {
            client = null;
            listener.Stop();
            listener = null;
            if (bwRead.IsBusy)
            {
                bwRead.CancelAsync();
            }
        }

        private void serverRead_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Console.WriteLine("Start1");
                client = listener.AcceptTcpClient();
                Console.WriteLine("Start2");
                STW = new StreamWriter(client.GetStream());
                STW.AutoFlush = true;

                try
                {
                    STR = new StreamReader(client.GetStream());
                    receive = STR.ReadLine();
                    if (!receive.Equals(""))
                    {

                        dataReceived = receive.Split(',');
                        Console.WriteLine(dataReceived[1]);

                        if (dataReceived[1].Equals("connectRequest")) /////////////////////////////////////////// Connect check
                        {
                            client = new TcpClient();
                            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(dataReceived[0]), 8010);

                            try
                            {
                                client.Connect(endPoint);
                                if (client.Connected)
                                {
                                    bwWrite.RunWorkerAsync();
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                            }
                        }
                        else ///////////////////////////////////////////////////////////////////////////////////// read Image
                        {
                            byte[] imgByte = Convert.FromBase64String(dataReceived[1]);
                            MemoryStream bitmapDataStream = new MemoryStream(imgByte);
                            Bitmap image = new Bitmap(bitmapDataStream);
                            Bitmap resize = new Bitmap(image, 400, 300);
                            Bitmap imgGray = grayscale.Apply(resize);
                            Bitmap imgCanny = canny.Apply(imgGray);

                            HistogramsOfOrientedGradients hog = new HistogramsOfOrientedGradients(9, 2, 16);
                            Bitmap resizeHOG = new Bitmap(imgCanny, 64, 128);
                            List<double[]> resultHOG = hog.ProcessImage(resizeHOG);
                            double[][] valueHog = new double[8][];
                            resultHOG.CopyTo(valueHog);
                            int count = 0;
                            String hogValues = "";
                            double[,] hogArray = new double[1, 288];

                            for (int j = 0; j < 8; j++)
                            {
                                for (int k = 0; k < 36; k++)
                                {
                                    if (count < 288)
                                    {
                                        hogArray[0, count] = valueHog[j][k];
                                        hogValues += string.Format("{0:0.000000}", hogArray[0, count]) + " ";
                                        count++;
                                    }
                                }
                            }

                            PredictResult = matlabPredict("0.000000", hogValues);

                            imgByte.Clear();
                            image.Dispose();
                            resize.Dispose();
                            imgGray.Dispose();
                            imgCanny.Dispose();

                            client = new TcpClient();
                            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(dataReceived[0]), 8010);
                            try
                            {
                                client.Connect(endPoint);
                                if (client.Connected)
                                {
                                    bwWrite.RunWorkerAsync();
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                            }
                        }
                        receive = "";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("JuJiiz " + ex);
                }
            }
            catch (SocketException SE)
            {
                Console.WriteLine("JuJiiz " + SE);
            }
        }

        private void serverWrite_DoWork(object sender, DoWorkEventArgs e)
        {
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;

            if (client.Connected)
            {
                if (dataReceived[1].Equals("connectRequest"))
                {
                    STW.WriteLine("OK");
                    bwRead.CancelAsync();
                }
                else
                {
                    STW.WriteLine(PredictResult);
                    //tbPredict.AppendText("Result (Client): " + PredictResult + "\n");
                    bwRead.CancelAsync();
                }
            }
            else
            {
                Console.WriteLine("Not Connected");
            }
            bwRead = new BackgroundWorker();
            bwRead.DoWork += new DoWorkEventHandler(serverRead_DoWork);
            bwRead.WorkerSupportsCancellation = true;
            bwRead.RunWorkerAsync();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}