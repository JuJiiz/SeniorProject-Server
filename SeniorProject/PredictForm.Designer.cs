namespace SeniorProject
{
    partial class PredictForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PredictForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFileLocal = new System.Windows.Forms.Label();
            this.btnVideoBrowse = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lbIP = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.btnServer = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbPredictStatus = new System.Windows.Forms.Label();
            this.bwPredict = new System.ComponentModel.BackgroundWorker();
            this.bwServerRead = new System.ComponentModel.BackgroundWorker();
            this.bwServerWrite = new System.ComponentModel.BackgroundWorker();
            this.tbPredict = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbExam = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbFileLocal);
            this.panel1.Location = new System.Drawing.Point(172, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 35);
            this.panel1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bangna New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(4, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Input Local: ";
            // 
            // lbFileLocal
            // 
            this.lbFileLocal.AutoSize = true;
            this.lbFileLocal.Font = new System.Drawing.Font("Bangna New", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbFileLocal.Location = new System.Drawing.Point(103, 8);
            this.lbFileLocal.Name = "lbFileLocal";
            this.lbFileLocal.Size = new System.Drawing.Size(53, 20);
            this.lbFileLocal.TabIndex = 2;
            this.lbFileLocal.Text = "No path";
            // 
            // btnVideoBrowse
            // 
            this.btnVideoBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(208)))), ((int)(((byte)(248)))));
            this.btnVideoBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVideoBrowse.FlatAppearance.BorderSize = 0;
            this.btnVideoBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoBrowse.Font = new System.Drawing.Font("Bangna New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnVideoBrowse.Location = new System.Drawing.Point(0, 0);
            this.btnVideoBrowse.Name = "btnVideoBrowse";
            this.btnVideoBrowse.Size = new System.Drawing.Size(172, 34);
            this.btnVideoBrowse.TabIndex = 17;
            this.btnVideoBrowse.Text = "Browse Video";
            this.btnVideoBrowse.UseVisualStyleBackColor = false;
            this.btnVideoBrowse.Click += new System.EventHandler(this.browse_click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(208)))), ((int)(((byte)(248)))));
            this.btnRun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRun.BackgroundImage")));
            this.btnRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Bangna New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnRun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRun.Location = new System.Drawing.Point(378, 32);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(112, 185);
            this.btnRun.TabIndex = 19;
            this.btnRun.Text = "Execute";
            this.btnRun.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.run_click);
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Font = new System.Drawing.Font("Bangna New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbIP.Location = new System.Drawing.Point(3, 8);
            this.lbIP.Name = "lbIP";
            this.lbIP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbIP.Size = new System.Drawing.Size(49, 22);
            this.lbIP.TabIndex = 20;
            this.lbIP.Text = "IPhere";
            this.lbIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Bangna New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbPort.Location = new System.Drawing.Point(3, 30);
            this.lbPort.Name = "lbPort";
            this.lbPort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbPort.Size = new System.Drawing.Size(69, 22);
            this.lbPort.TabIndex = 21;
            this.lbPort.Text = "PORThere";
            this.lbPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(208)))), ((int)(((byte)(248)))));
            this.btnServer.FlatAppearance.BorderSize = 0;
            this.btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServer.Font = new System.Drawing.Font("Bangna New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnServer.Location = new System.Drawing.Point(334, 0);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(156, 87);
            this.btnServer.TabIndex = 23;
            this.btnServer.Text = "Start Server";
            this.btnServer.UseVisualStyleBackColor = false;
            this.btnServer.Click += new System.EventHandler(this.StartServer_click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Bangna New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbStatus.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Location = new System.Drawing.Point(3, 54);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(74, 29);
            this.lbStatus.TabIndex = 24;
            this.lbStatus.Text = "Offline";
            // 
            // lbPredictStatus
            // 
            this.lbPredictStatus.AutoSize = true;
            this.lbPredictStatus.Font = new System.Drawing.Font("Bangna New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbPredictStatus.Location = new System.Drawing.Point(388, 240);
            this.lbPredictStatus.Name = "lbPredictStatus";
            this.lbPredictStatus.Size = new System.Drawing.Size(36, 22);
            this.lbPredictStatus.TabIndex = 26;
            this.lbPredictStatus.Text = "Idle";
            // 
            // bwPredict
            // 
            this.bwPredict.DoWork += new System.ComponentModel.DoWorkEventHandler(this.predict_DoWork);
            this.bwPredict.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.predict_Change);
            this.bwPredict.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.predict_Completed);
            // 
            // bwServerRead
            // 
            this.bwServerRead.DoWork += new System.ComponentModel.DoWorkEventHandler(this.serverRead_DoWork);
            // 
            // bwServerWrite
            // 
            this.bwServerWrite.DoWork += new System.ComponentModel.DoWorkEventHandler(this.serverWrite_DoWork);
            // 
            // tbPredict
            // 
            this.tbPredict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.tbPredict.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPredict.Location = new System.Drawing.Point(-1, 217);
            this.tbPredict.Multiline = true;
            this.tbPredict.Name = "tbPredict";
            this.tbPredict.ReadOnly = true;
            this.tbPredict.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPredict.Size = new System.Drawing.Size(383, 67);
            this.tbPredict.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbStatus);
            this.panel2.Controls.Add(this.lbPort);
            this.panel2.Controls.Add(this.lbIP);
            this.panel2.Controls.Add(this.btnServer);
            this.panel2.Location = new System.Drawing.Point(1, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 87);
            this.panel2.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbPredictStatus);
            this.panel3.Controls.Add(this.pbExam);
            this.panel3.Controls.Add(this.btnRun);
            this.panel3.Controls.Add(this.tbPredict);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnVideoBrowse);
            this.panel3.Location = new System.Drawing.Point(1, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 285);
            this.panel3.TabIndex = 30;
            // 
            // pbExam
            // 
            this.pbExam.BackColor = System.Drawing.Color.DimGray;
            this.pbExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbExam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbExam.Location = new System.Drawing.Point(0, 32);
            this.pbExam.Name = "pbExam";
            this.pbExam.Size = new System.Drawing.Size(382, 185);
            this.pbExam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExam.TabIndex = 28;
            this.pbExam.TabStop = false;
            // 
            // pbClose
            // 
            this.pbClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbClose.BackgroundImage")));
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(459, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(21, 22);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 31;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // PredictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(492, 423);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PredictForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PredictForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_Closed);
            this.Load += new System.EventHandler(this.form_load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbFileLocal;
        private System.Windows.Forms.Button btnVideoBrowse;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbPredictStatus;
        private System.ComponentModel.BackgroundWorker bwPredict;
        private System.ComponentModel.BackgroundWorker bwServerRead;
        private System.ComponentModel.BackgroundWorker bwServerWrite;
        private System.Windows.Forms.TextBox tbPredict;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbExam;
        private System.Windows.Forms.PictureBox pbClose;
    }
}