using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorProject
{
    public partial class StartProgram : Form
    {
        BackgroundWorker bw = new BackgroundWorker();

        public StartProgram()
        {
            InitializeComponent();

            bw.WorkerReportsProgress = true;
            bw.DoWork += new DoWorkEventHandler(start_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(start_Completed);
        }

        private void StartProgram_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 501; i++)
            {
                if (i == 500)
                {
                    bw.RunWorkerAsync();
                }
            }
        }

        private void start_DoWork(object sender, DoWorkEventArgs e)
        {
            MLApp.MLApp matlab = new MLApp.MLApp();
        }

        private void start_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
