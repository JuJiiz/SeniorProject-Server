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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            MLApp.MLApp matlab = new MLApp.MLApp();
        }

        private void predict_click(object sender, EventArgs e)
        {
            PredictForm predictForm = new PredictForm();
            predictForm.ShowDialog();
        }

        private void train_click(object sender, EventArgs e)
        {
            TrainForm trainForm = new TrainForm();
            trainForm.ShowDialog();
        }
    }
}
