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
        
        MLApp.MLApp matlab;

        String[] dataReceived = new String[2];

        TcpListener listener;
        TcpClient client;
        StreamReader STR;
        StreamWriter STW;
        String receive = "";

        int PredictResult = 0;

        Grayscale grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
        CannyEdgeDetector canny = new CannyEdgeDetector(0, 5);

        bool ServerWorking = false;

        BackgroundWorker bw = new BackgroundWorker();
        BackgroundWorker bwRead = new BackgroundWorker();
        BackgroundWorker bwWrite = new BackgroundWorker();

        public PredictForm()
        {
            InitializeComponent();

            matlab = new MLApp.MLApp();

            bw.WorkerReportsProgress = true;
            bw.DoWork += new DoWorkEventHandler(predict_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(predict_Change);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(predict_Completed);

            bwRead.DoWork += new DoWorkEventHandler(serverRead_DoWork);

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

        private void run_click(object sender, EventArgs e)
        {
            if (!InputPath.Equals("NoPath"))
            {
                btnRun.Enabled = false;
                tbPredict.Clear();
                bw.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Please Select \"Video Input\" ", "Predict");
            }
        }
        
        //Execute Matlab OSELM Predict
        private int matlab_execute(String hogClass,String hogValue)
        {
            matlab.Execute("cd " + AppDomain.CurrentDomain.BaseDirectory);
            object result = null;
            matlab.Feval("OSELM_predict", 1, out result, hogClass, hogValue);
            object[] res = result as object[];
            matlab.Quit();

            return Convert.ToInt32(res[0]);
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

        }

        private void StartServer_click(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Parse(lbIP.Text), 8010);
            listener.Start();
            ServerWorking = true;
            bwRead.RunWorkerAsync();
            Console.WriteLine("Start");
            lbStatus.Text = "Online";
            btnServer.Enabled = false;
            lbStatus.ForeColor = Color.Green;

            //Start server host
            //if (bwServer.IsBusy)
            //{
            //    listener.Stop();
            //    bwServer.CancelAsync();
            //    lbStatus.Text = "Offline";
            //    lbStatus.ForeColor = Color.Red;
            //    btnServer.Text = "Start Server";
            //    Console.WriteLine("Stop");
            //}
            //else if(!bwServer.CancellationPending)
            //{
            //    bwServer.RunWorkerAsync();
            //    Console.WriteLine("Start");
            //    lbStatus.Text = "Online";
            //    btnServer.Text = "Stop Server";
            //    lbStatus.ForeColor = Color.Green;
            //}
        }

        private void predict_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(11);

            VideoFileReader read = new VideoFileReader();
            read.Open(InputPath);

            double[,] hogArray = new double[read.FrameCount - 1, 288];
            int predictResult = 0;

            for (int i = 0; i < read.FrameCount - 1; i++)
            {
                Bitmap image = read.ReadVideoFrame(i);
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

                predictResult = matlab_execute("0.000000", hogValues);

                worker.ReportProgress(predictResult);

                //Clear value(Reduce RAM usage)
                image.Dispose();
                resize.Dispose();
                imgGray.Dispose();
                imgCanny.Dispose();
            }
        }

        private void predict_Change(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage.ToString().Equals("11"))
            {
                this.lbPredictStatus.Text = "Data Preparing...";
                this.lbPredictStatus.ForeColor = Color.Red;
            }
            else if (e.ProgressPercentage.ToString().Equals("22"))
            {
                this.lbPredictStatus.Text = "Predict Processing...";
                this.lbPredictStatus.ForeColor = Color.Red;
            }

            if (e.ProgressPercentage.ToString().Equals("1"))
            {
                //this.lbOutput.Text = "Class1";
                tbPredict.AppendText("Class1\n");
            }
            else if (e.ProgressPercentage.ToString().Equals("2"))
            {
                //this.lbOutput.Text = "Class2";
                tbPredict.AppendText("Class2\n");
            }
            else if (e.ProgressPercentage.ToString().Equals("3"))
            {
                //this.lbOutput.Text = "Class3";
                tbPredict.AppendText("Class3\n");
            }
            else if (e.ProgressPercentage.ToString().Equals("4"))
            {
                //this.lbOutput.Text = "Class4";
                tbPredict.AppendText("Class4\n");
            }
            else if (e.ProgressPercentage.ToString().Equals("5"))
            {
                //this.lbOutput.Text = "Class5";
                tbPredict.AppendText("Class5\n");
            }
            else if (e.ProgressPercentage.ToString().Equals("6"))
            {
                //this.lbOutput.Text = "Class6";
                tbPredict.AppendText("Class6\n");
            }
        }

        private void predict_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            this.lbPredictStatus.Text = "Idle";
            this.lbPredictStatus.ForeColor = Color.Black;
            btnRun.Enabled = true;
            MessageBox.Show("Successfully.", "Predict");
        }

        private void form_Closed(object sender, FormClosedEventArgs e)
        {

        }

        private void serverRead_DoWork(object sender, DoWorkEventArgs e)
        {

            while (ServerWorking == true)
            {
                client = listener.AcceptTcpClient();
                STW = new StreamWriter(client.GetStream());
                STW.AutoFlush = true;

                try
                {
                    STR = new StreamReader(client.GetStream());
                    receive = STR.ReadLine();
                    if (!receive.Equals(""))
                    {
                        //lbTest.Invoke(new MethodInvoker(delegate () { lbTest.Text = receive; }));

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

                            PredictResult = matlab_execute("0.000000", hogValues);

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
                    Console.WriteLine(ex);
                }
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
                }
                else
                {
                    STW.WriteLine(PredictResult);
                }
            }
            else
            {
                Console.WriteLine("Not Connected");
            }
        }
    }
}
