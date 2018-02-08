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
            this.pbExample = new System.Windows.Forms.PictureBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExample)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVideoBrowse
            // 
            this.btnVideoBrowse.Location = new System.Drawing.Point(12, 250);
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
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Local: ";
            // 
            // lbFileLocal
            // 
            this.lbFileLocal.AutoSize = true;
            this.lbFileLocal.Location = new System.Drawing.Point(67, 9);
            this.lbFileLocal.Name = "lbFileLocal";
            this.lbFileLocal.Size = new System.Drawing.Size(22, 13);
            this.lbFileLocal.TabIndex = 2;
            this.lbFileLocal.Text = "xxx";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbFileLocal);
            this.panel1.Location = new System.Drawing.Point(138, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 29);
            this.panel1.TabIndex = 4;
            // 
            // pbExample
            // 
            this.pbExample.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbExample.Location = new System.Drawing.Point(12, 12);
            this.pbExample.Name = "pbExample";
            this.pbExample.Size = new System.Drawing.Size(477, 222);
            this.pbExample.TabIndex = 10;
            this.pbExample.TabStop = false;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(413, 285);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 58);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.run_click);
            // 
            // TrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 355);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.pbExample);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVideoBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TrainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExample)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVideoBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFileLocal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbExample;
        private System.Windows.Forms.Button btnRun;
    }
}