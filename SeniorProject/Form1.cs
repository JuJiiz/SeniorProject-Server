using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SeniorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            MLApp.MLApp matlab = new MLApp.MLApp();
        }

        private void predict_click(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Matlab\\OSELM_model.mat"))
            {
                //this.Hide();
                //var predictForm = new PredictForm();
                //predictForm.Closed += (s, args) => this.Close();
                //predictForm.Show();
                PredictForm predictForm = new PredictForm();
                predictForm.Show();
            }
            else
            {
                MessageBox.Show("Please train before predict.");
            }
        }

        private void train_click(object sender, EventArgs e)
        {
            //this.Hide();
            //var trainForm = new TrainForm();
            //trainForm.Closed += (s, args) => this.Close();
            //trainForm.Show();
            TrainForm trainForm = new TrainForm();
            trainForm.Show();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
