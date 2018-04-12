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
            this.btnVideoBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFileLocal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbClass3 = new System.Windows.Forms.RadioButton();
            this.rbClass2 = new System.Windows.Forms.RadioButton();
            this.rbClass1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbClass6 = new System.Windows.Forms.RadioButton();
            this.rbClass5 = new System.Windows.Forms.RadioButton();
            this.rbClass4 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.bwProcess = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVideoBrowse
            // 
            this.btnVideoBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnVideoBrowse.Location = new System.Drawing.Point(17, 56);
            this.btnVideoBrowse.Name = "btnVideoBrowse";
            this.btnVideoBrowse.Size = new System.Drawing.Size(120, 29);
            this.btnVideoBrowse.TabIndex = 0;
            this.btnVideoBrowse.Text = "Browse Video";
            this.btnVideoBrowse.UseVisualStyleBackColor = true;
            this.btnVideoBrowse.Click += new System.EventHandler(this.browse_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Local: ";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbFileLocal);
            this.panel1.Location = new System.Drawing.Point(143, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 29);
            this.panel1.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.LawnGreen;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnRun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRun.Location = new System.Drawing.Point(195, 285);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(169, 65);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Execute";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.run_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Video Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Class";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbClass3);
            this.groupBox1.Controls.Add(this.rbClass2);
            this.groupBox1.Controls.Add(this.rbClass1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(31, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 120);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "On-Road";
            // 
            // rbClass3
            // 
            this.rbClass3.AutoSize = true;
            this.rbClass3.Location = new System.Drawing.Point(6, 85);
            this.rbClass3.Name = "rbClass3";
            this.rbClass3.Size = new System.Drawing.Size(72, 24);
            this.rbClass3.TabIndex = 2;
            this.rbClass3.TabStop = true;
            this.rbClass3.Text = "class3";
            this.rbClass3.UseVisualStyleBackColor = true;
            // 
            // rbClass2
            // 
            this.rbClass2.AutoSize = true;
            this.rbClass2.Location = new System.Drawing.Point(6, 55);
            this.rbClass2.Name = "rbClass2";
            this.rbClass2.Size = new System.Drawing.Size(72, 24);
            this.rbClass2.TabIndex = 1;
            this.rbClass2.TabStop = true;
            this.rbClass2.Text = "class2";
            this.rbClass2.UseVisualStyleBackColor = true;
            // 
            // rbClass1
            // 
            this.rbClass1.AutoSize = true;
            this.rbClass1.Location = new System.Drawing.Point(6, 25);
            this.rbClass1.Name = "rbClass1";
            this.rbClass1.Size = new System.Drawing.Size(195, 24);
            this.rbClass1.TabIndex = 0;
            this.rbClass1.TabStop = true;
            this.rbClass1.Text = "On correct lane (Middle)";
            this.rbClass1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbClass6);
            this.groupBox2.Controls.Add(this.rbClass5);
            this.groupBox2.Controls.Add(this.rbClass4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox2.Location = new System.Drawing.Point(296, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 120);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Off-Road";
            // 
            // rbClass6
            // 
            this.rbClass6.AutoSize = true;
            this.rbClass6.Location = new System.Drawing.Point(6, 85);
            this.rbClass6.Name = "rbClass6";
            this.rbClass6.Size = new System.Drawing.Size(72, 24);
            this.rbClass6.TabIndex = 2;
            this.rbClass6.TabStop = true;
            this.rbClass6.Text = "class6";
            this.rbClass6.UseVisualStyleBackColor = true;
            // 
            // rbClass5
            // 
            this.rbClass5.AutoSize = true;
            this.rbClass5.Location = new System.Drawing.Point(6, 55);
            this.rbClass5.Name = "rbClass5";
            this.rbClass5.Size = new System.Drawing.Size(72, 24);
            this.rbClass5.TabIndex = 1;
            this.rbClass5.TabStop = true;
            this.rbClass5.Text = "class5";
            this.rbClass5.UseVisualStyleBackColor = true;
            // 
            // rbClass4
            // 
            this.rbClass4.AutoSize = true;
            this.rbClass4.Location = new System.Drawing.Point(6, 25);
            this.rbClass4.Name = "rbClass4";
            this.rbClass4.Size = new System.Drawing.Size(93, 24);
            this.rbClass4.TabIndex = 0;
            this.rbClass4.TabStop = true;
            this.rbClass4.Text = "Head out";
            this.rbClass4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(12, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "STATUS: ";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(75, 354);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(24, 13);
            this.lbStatus.TabIndex = 19;
            this.lbStatus.Text = "Idle";
            // 
            // bwProcess
            // 
            this.bwProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.process_DoWork);
            this.bwProcess.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.process_Change);
            this.bwProcess.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.process_Completed);
            // 
            // TrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(558, 376);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVideoBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Train";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVideoBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFileLocal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbClass3;
        private System.Windows.Forms.RadioButton rbClass2;
        private System.Windows.Forms.RadioButton rbClass1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbClass6;
        private System.Windows.Forms.RadioButton rbClass5;
        private System.Windows.Forms.RadioButton rbClass4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbStatus;
        private System.ComponentModel.BackgroundWorker bwProcess;
    }
}