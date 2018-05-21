namespace SeniorProject
{
    partial class StartProgram
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
            this.lbOpen = new System.Windows.Forms.Label();
            this.bwStart = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lbOpen
            // 
            this.lbOpen.AutoSize = true;
            this.lbOpen.Font = new System.Drawing.Font("Bangna New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbOpen.Location = new System.Drawing.Point(79, 26);
            this.lbOpen.Name = "lbOpen";
            this.lbOpen.Size = new System.Drawing.Size(125, 37);
            this.lbOpen.TabIndex = 0;
            this.lbOpen.Text = "Opening...";
            // 
            // bwStart
            // 
            this.bwStart.DoWork += new System.ComponentModel.DoWorkEventHandler(this.start_DoWork);
            this.bwStart.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.start_Completed);
            // 
            // StartProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(289, 91);
            this.Controls.Add(this.lbOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartProgram";
            this.Load += new System.EventHandler(this.StartProgram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOpen;
        private System.ComponentModel.BackgroundWorker bwStart;
    }
}