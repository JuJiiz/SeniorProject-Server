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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label5 = new System.Windows.Forms.Label();
            this.bwPredict = new System.ComponentModel.BackgroundWorker();
            this.bwServerRead = new System.ComponentModel.BackgroundWorker();
            this.bwServerWrite = new System.ComponentModel.BackgroundWorker();
            this.tbPredict = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Video Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Output:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbFileLocal);
            this.panel1.Location = new System.Drawing.Point(138, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 29);
            this.panel1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Input Local: ";
            // 
            // lbFileLocal
            // 
            this.lbFileLocal.AutoSize = true;
            this.lbFileLocal.Location = new System.Drawing.Point(67, 9);
            this.lbFileLocal.Name = "lbFileLocal";
            this.lbFileLocal.Size = new System.Drawing.Size(45, 13);
            this.lbFileLocal.TabIndex = 2;
            this.lbFileLocal.Text = "No path";
            // 
            // btnVideoBrowse
            // 
            this.btnVideoBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnVideoBrowse.Location = new System.Drawing.Point(12, 132);
            this.btnVideoBrowse.Name = "btnVideoBrowse";
            this.btnVideoBrowse.Size = new System.Drawing.Size(120, 46);
            this.btnVideoBrowse.TabIndex = 17;
            this.btnVideoBrowse.Text = "Browse Video";
            this.btnVideoBrowse.UseVisualStyleBackColor = true;
            this.btnVideoBrowse.Click += new System.EventHandler(this.browse_click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.LawnGreen;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnRun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRun.Location = new System.Drawing.Point(355, 201);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 65);
            this.btnRun.TabIndex = 19;
            this.btnRun.Text = "Execute";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.run_click);
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(12, 9);
            this.lbIP.Name = "lbIP";
            this.lbIP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbIP.Size = new System.Drawing.Size(38, 13);
            this.lbIP.TabIndex = 20;
            this.lbIP.Text = "IPhere";
            this.lbIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(12, 28);
            this.lbPort.Name = "lbPort";
            this.lbPort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbPort.Size = new System.Drawing.Size(58, 13);
            this.lbPort.TabIndex = 21;
            this.lbPort.Text = "PORThere";
            this.lbPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.Color.LightGray;
            this.btnServer.Location = new System.Drawing.Point(380, 12);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(75, 50);
            this.btnServer.TabIndex = 23;
            this.btnServer.Text = "Start Server";
            this.btnServer.UseVisualStyleBackColor = false;
            this.btnServer.Click += new System.EventHandler(this.StartServer_click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbStatus.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Location = new System.Drawing.Point(12, 49);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(44, 13);
            this.lbStatus.TabIndex = 24;
            this.lbStatus.Text = "Offline";
            // 
            // lbPredictStatus
            // 
            this.lbPredictStatus.AutoSize = true;
            this.lbPredictStatus.Location = new System.Drawing.Point(72, 399);
            this.lbPredictStatus.Name = "lbPredictStatus";
            this.lbPredictStatus.Size = new System.Drawing.Size(24, 13);
            this.lbPredictStatus.TabIndex = 26;
            this.lbPredictStatus.Text = "Idle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(9, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "STATUS: ";
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
            this.tbPredict.BackColor = System.Drawing.Color.White;
            this.tbPredict.Location = new System.Drawing.Point(89, 201);
            this.tbPredict.Multiline = true;
            this.tbPredict.Name = "tbPredict";
            this.tbPredict.ReadOnly = true;
            this.tbPredict.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPredict.Size = new System.Drawing.Size(250, 185);
            this.tbPredict.TabIndex = 27;
            // 
            // PredictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 421);
            this.Controls.Add(this.tbPredict);
            this.Controls.Add(this.lbPredictStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVideoBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PredictForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PredictForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_Closed);
            this.Load += new System.EventHandler(this.form_load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker bwPredict;
        private System.ComponentModel.BackgroundWorker bwServerRead;
        private System.ComponentModel.BackgroundWorker bwServerWrite;
        private System.Windows.Forms.TextBox tbPredict;
    }
}