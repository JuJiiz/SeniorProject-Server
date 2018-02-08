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
        }

        private void predict_click(object sender, EventArgs e)
        {
            
        }

        private void train_click(object sender, EventArgs e)
        {
            TrainForm trainform = new TrainForm();
            trainform.ShowDialog(); // Shows Form2
        }
    }
}
