using Accord.Imaging.Filters;
using Accord.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorProject
{
    public partial class TrainForm : Form
    {
        private String VideoInputPath = "";
        private String VideoOutputPath = "";
        public TrainForm()
        {
            InitializeComponent();
        }

        private void browse_click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.lbFileLocal.Text = open.FileName;
                VideoInputPath = open.FileName;
            }
        }

        private void run_click(object sender, EventArgs e)
        {
            if (!lbFileLocal.Text.Equals("xxx"))
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        string[] files = Directory.GetFiles(fbd.SelectedPath);
                        VideoOutputPath = fbd.SelectedPath;
                        //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");

                        VideoFileReader read = new VideoFileReader();
                        read.Open(VideoInputPath);
                        Grayscale f1 = new Grayscale(0.2125, 0.7154, 0.0721);
                        HistogramEqualization f3 = new HistogramEqualization();
                        CannyEdgeDetector fiw = new CannyEdgeDetector(0, 5);
                        OtsuThreshold f4 = new OtsuThreshold();
                        HorizontalRunLengthSmoothing f6 = new HorizontalRunLengthSmoothing(10);
                        VerticalRunLengthSmoothing f7 = new VerticalRunLengthSmoothing(30);
                        GaussianBlur fiii = new GaussianBlur();
                        HSLFiltering filter = new HSLFiltering();
                        filter.Luminance = new Accord.Range(0.95f, 1);
                        for (int i = 0; i < read.FrameCount; i++)
                        {
                            Bitmap image = read.ReadVideoFrame();
                            Bitmap box = new Bitmap(image, 400, 300);
                            Bitmap w1 = f3.Apply(box);
                            Bitmap w2 = filter.Apply(w1);
                            Bitmap w3 = f1.Apply(w2);
                            Bitmap ax5 = fiii.Apply(w3);
                            Bitmap ax6 = fiw.Apply(ax5);
                            Bitmap w4 = f4.Apply(ax5);
                            Bitmap ax7 = fiw.Apply(w4);

                            ax6.Save(VideoOutputPath + "/normal/" + i + ".jpg" , ImageFormat.Jpeg);
                            ax7.Save(VideoOutputPath + "/otsu/" + i + ".jpg", ImageFormat.Jpeg);
                            ax5.Dispose();
                            box.Dispose();
                            image.Dispose();
                            ax6.Dispose();
                            ax7.Dispose();
                            w1.Dispose();
                            w2.Dispose();
                            w3.Dispose();
                            w4.Dispose();
                        }
                    }
                }
            }
            else
            {

            }
            
        }
    }
}
