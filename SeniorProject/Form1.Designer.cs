namespace SeniorProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnPredict = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(338, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(21, 22);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 33;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnTrain);
            this.panel1.Controls.Add(this.btnPredict);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 123);
            this.panel1.TabIndex = 34;
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(208)))), ((int)(((byte)(248)))));
            this.btnTrain.FlatAppearance.BorderSize = 0;
            this.btnTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrain.Font = new System.Drawing.Font("Bangna New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnTrain.Location = new System.Drawing.Point(3, 3);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(172, 114);
            this.btnTrain.TabIndex = 1;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = false;
            this.btnTrain.Click += new System.EventHandler(this.train_click);
            // 
            // btnPredict
            // 
            this.btnPredict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(208)))), ((int)(((byte)(248)))));
            this.btnPredict.FlatAppearance.BorderSize = 0;
            this.btnPredict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPredict.Font = new System.Drawing.Font("Bangna New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnPredict.Location = new System.Drawing.Point(193, 3);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(172, 114);
            this.btnPredict.TabIndex = 0;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = false;
            this.btnPredict.Click += new System.EventHandler(this.predict_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 155);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Road Detection";
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnPredict;
    }
}

