namespace SeniorProject
{
    partial class TrainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainForm));
            this.btnVideoBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFileLocal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbClass3 = new System.Windows.Forms.RadioButton();
            this.rbClass2 = new System.Windows.Forms.RadioButton();
            this.rbClass4 = new System.Windows.Forms.RadioButton();
            this.rbClass1 = new System.Windows.Forms.RadioButton();
            this.lbStatus = new System.Windows.Forms.Label();
            this.bwProcess = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVideoBrowse
            // 
            this.btnVideoBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(208)))), ((int)(((byte)(248)))));
            this.btnVideoBrowse.FlatAppearance.BorderSize = 0;
            this.btnVideoBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoBrowse.Font = new System.Drawing.Font("Bangna New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnVideoBrowse.Location = new System.Drawing.Point(0, 30);
            this.btnVideoBrowse.Name = "btnVideoBrowse";
            this.btnVideoBrowse.Size = new System.Drawing.Size(133, 29);
            this.btnVideoBrowse.TabIndex = 0;
            this.btnVideoBrowse.Text = "Browse Video";
            this.btnVideoBrowse.UseVisualStyleBackColor = false;
            this.btnVideoBrowse.Click += new System.EventHandler(this.browse_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bangna New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Local: ";
            // 
            // lbFileLocal
            // 
            this.lbFileLocal.AutoSize = true;
            this.lbFileLocal.Location = new System.Drawing.Point(101, 4);
            this.lbFileLocal.Name = "lbFileLocal";
            this.lbFileLocal.Size = new System.Drawing.Size(53, 20);
            this.lbFileLocal.TabIndex = 2;
            this.lbFileLocal.Text = "No path";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbFileLocal);
            this.panel1.Font = new System.Drawing.Font("Bangna New", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.panel1.Location = new System.Drawing.Point(130, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 29);
            this.panel1.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(208)))), ((int)(((byte)(248)))));
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Bangna New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnRun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.Location = new System.Drawing.Point(227, 65);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(189, 112);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Execute";
            this.btnRun.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.run_click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.groupBox1.Controls.Add(this.rbClass3);
            this.groupBox1.Controls.Add(this.rbClass2);
            this.groupBox1.Controls.Add(this.rbClass4);
            this.groupBox1.Controls.Add(this.rbClass1);
            this.groupBox1.Font = new System.Drawing.Font("Bangna New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(0, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 156);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Class";
            // 
            // rbClass3
            // 
            this.rbClass3.AutoSize = true;
            this.rbClass3.Location = new System.Drawing.Point(6, 85);
            this.rbClass3.Name = "rbClass3";
            this.rbClass3.Size = new System.Drawing.Size(171, 27);
            this.rbClass3.TabIndex = 2;
            this.rbClass3.TabStop = true;
            this.rbClass3.Text = "On correct lane (Right)";
            this.rbClass3.UseVisualStyleBackColor = true;
            // 
            // rbClass2
            // 
            this.rbClass2.AutoSize = true;
            this.rbClass2.Location = new System.Drawing.Point(6, 55);
            this.rbClass2.Name = "rbClass2";
            this.rbClass2.Size = new System.Drawing.Size(165, 27);
            this.rbClass2.TabIndex = 1;
            this.rbClass2.TabStop = true;
            this.rbClass2.Text = "On correct lane (Left)";
            this.rbClass2.UseVisualStyleBackColor = true;
            // 
            // rbClass4
            // 
            this.rbClass4.AutoSize = true;
            this.rbClass4.Location = new System.Drawing.Point(6, 115);
            this.rbClass4.Name = "rbClass4";
            this.rbClass4.Size = new System.Drawing.Size(86, 27);
            this.rbClass4.TabIndex = 0;
            this.rbClass4.TabStop = true;
            this.rbClass4.Text = "Head out";
            this.rbClass4.UseVisualStyleBackColor = true;
            // 
            // rbClass1
            // 
            this.rbClass1.AutoSize = true;
            this.rbClass1.Location = new System.Drawing.Point(6, 25);
            this.rbClass1.Name = "rbClass1";
            this.rbClass1.Size = new System.Drawing.Size(178, 27);
            this.rbClass1.TabIndex = 0;
            this.rbClass1.TabStop = true;
            this.rbClass1.Text = "On correct lane (Middle)";
            this.rbClass1.UseVisualStyleBackColor = true;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Bangna New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbStatus.Location = new System.Drawing.Point(231, 158);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(36, 23);
            this.lbStatus.TabIndex = 19;
            this.lbStatus.Text = "Idle";
            // 
            // bwProcess
            // 
            this.bwProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.process_DoWork);
            this.bwProcess.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.process_Change);
            this.bwProcess.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.process_Completed);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbStatus);
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 191);
            this.panel2.TabIndex = 20;
            // 
            // pbClose
            // 
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(382, 2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(21, 22);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 32;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // TrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(415, 221);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVideoBrowse);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Train";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVideoBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFileLocal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbClass3;
        private System.Windows.Forms.RadioButton rbClass2;
        private System.Windows.Forms.RadioButton rbClass1;
        private System.Windows.Forms.RadioButton rbClass4;
        private System.Windows.Forms.Label lbStatus;
        private System.ComponentModel.BackgroundWorker bwProcess;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbClose;
    }
}