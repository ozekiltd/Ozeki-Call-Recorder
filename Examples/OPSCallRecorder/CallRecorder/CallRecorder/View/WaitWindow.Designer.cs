namespace CallRecorder.View
{
    partial class WaitWindow
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
			this.p_Main = new System.Windows.Forms.Panel();
			this.lbl_PleaseWait = new System.Windows.Forms.Label();
			this.pb_ProgressBar = new System.Windows.Forms.ProgressBar();
			this.p_Main.SuspendLayout();
			this.SuspendLayout();
			// 
			// p_Main
			// 
			this.p_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_Main.Controls.Add(this.lbl_PleaseWait);
			this.p_Main.Controls.Add(this.pb_ProgressBar);
			this.p_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Main.Location = new System.Drawing.Point(0, 0);
			this.p_Main.Name = "p_Main";
			this.p_Main.Size = new System.Drawing.Size(423, 70);
			this.p_Main.TabIndex = 0;
			// 
			// lbl_PleaseWait
			// 
			this.lbl_PleaseWait.AutoSize = true;
			this.lbl_PleaseWait.Location = new System.Drawing.Point(9, 9);
			this.lbl_PleaseWait.Name = "lbl_PleaseWait";
			this.lbl_PleaseWait.Size = new System.Drawing.Size(70, 13);
			this.lbl_PleaseWait.TabIndex = 1;
			this.lbl_PleaseWait.Text = "Please wait...";
			// 
			// pb_ProgressBar
			// 
			this.pb_ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pb_ProgressBar.Location = new System.Drawing.Point(12, 34);
			this.pb_ProgressBar.Name = "pb_ProgressBar";
			this.pb_ProgressBar.Size = new System.Drawing.Size(399, 23);
			this.pb_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.pb_ProgressBar.TabIndex = 0;
			// 
			// WaitWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(423, 70);
			this.Controls.Add(this.p_Main);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "WaitWindow";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WaitWindow";
			this.TopMost = true;
			this.Shown += new System.EventHandler(this.WaitWindow_Shown);
			this.p_Main.ResumeLayout(false);
			this.p_Main.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_Main;
        private System.Windows.Forms.Label lbl_PleaseWait;
        private System.Windows.Forms.ProgressBar pb_ProgressBar;
    }
}