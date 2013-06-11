namespace CallRecorder.View
{
	partial class OptionsWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsWindow));
			this.p_Main = new System.Windows.Forms.Panel();
			this.gb_RecordingPath = new System.Windows.Forms.GroupBox();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_OK = new System.Windows.Forms.Button();
			this.btn_Browse = new System.Windows.Forms.Button();
			this.tb_Browse = new System.Windows.Forms.TextBox();
			this.gb_Options = new System.Windows.Forms.GroupBox();
			this.rb_Wav = new System.Windows.Forms.RadioButton();
			this.rb_Mp3 = new System.Windows.Forms.RadioButton();
			this.fbd_Browse = new System.Windows.Forms.FolderBrowserDialog();
			this.p_Main.SuspendLayout();
			this.gb_RecordingPath.SuspendLayout();
			this.gb_Options.SuspendLayout();
			this.SuspendLayout();
			// 
			// p_Main
			// 
			this.p_Main.Controls.Add(this.gb_RecordingPath);
			this.p_Main.Controls.Add(this.gb_Options);
			this.p_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Main.Location = new System.Drawing.Point(0, 0);
			this.p_Main.Name = "p_Main";
			this.p_Main.Size = new System.Drawing.Size(477, 140);
			this.p_Main.TabIndex = 0;
			// 
			// gb_RecordingPath
			// 
			this.gb_RecordingPath.Controls.Add(this.btn_Cancel);
			this.gb_RecordingPath.Controls.Add(this.btn_OK);
			this.gb_RecordingPath.Controls.Add(this.btn_Browse);
			this.gb_RecordingPath.Controls.Add(this.tb_Browse);
			this.gb_RecordingPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_RecordingPath.Location = new System.Drawing.Point(0, 65);
			this.gb_RecordingPath.Name = "gb_RecordingPath";
			this.gb_RecordingPath.Size = new System.Drawing.Size(477, 75);
			this.gb_RecordingPath.TabIndex = 1;
			this.gb_RecordingPath.TabStop = false;
			this.gb_RecordingPath.Text = "Recording path";
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.Location = new System.Drawing.Point(396, 45);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 3;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			// 
			// btn_OK
			// 
			this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btn_OK.Location = new System.Drawing.Point(315, 45);
			this.btn_OK.Name = "btn_OK";
			this.btn_OK.Size = new System.Drawing.Size(75, 23);
			this.btn_OK.TabIndex = 2;
			this.btn_OK.Text = "OK";
			this.btn_OK.UseVisualStyleBackColor = true;
			this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
			// 
			// btn_Browse
			// 
			this.btn_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Browse.Location = new System.Drawing.Point(396, 17);
			this.btn_Browse.Name = "btn_Browse";
			this.btn_Browse.Size = new System.Drawing.Size(75, 23);
			this.btn_Browse.TabIndex = 1;
			this.btn_Browse.Text = "Browse";
			this.btn_Browse.UseVisualStyleBackColor = true;
			this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
			// 
			// tb_Browse
			// 
			this.tb_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Browse.Location = new System.Drawing.Point(12, 19);
			this.tb_Browse.Name = "tb_Browse";
			this.tb_Browse.Size = new System.Drawing.Size(378, 20);
			this.tb_Browse.TabIndex = 0;
			// 
			// gb_Options
			// 
			this.gb_Options.Controls.Add(this.rb_Wav);
			this.gb_Options.Controls.Add(this.rb_Mp3);
			this.gb_Options.Dock = System.Windows.Forms.DockStyle.Top;
			this.gb_Options.Location = new System.Drawing.Point(0, 0);
			this.gb_Options.Name = "gb_Options";
			this.gb_Options.Size = new System.Drawing.Size(477, 65);
			this.gb_Options.TabIndex = 0;
			this.gb_Options.TabStop = false;
			this.gb_Options.Text = "Recording format";
			// 
			// rb_Wav
			// 
			this.rb_Wav.AutoSize = true;
			this.rb_Wav.Location = new System.Drawing.Point(12, 42);
			this.rb_Wav.Name = "rb_Wav";
			this.rb_Wav.Size = new System.Drawing.Size(133, 17);
			this.rb_Wav.TabIndex = 1;
			this.rb_Wav.TabStop = true;
			this.rb_Wav.Text = "Waveform Audio (wav)";
			this.rb_Wav.UseVisualStyleBackColor = true;
			// 
			// rb_Mp3
			// 
			this.rb_Mp3.AutoSize = true;
			this.rb_Mp3.Location = new System.Drawing.Point(12, 19);
			this.rb_Mp3.Name = "rb_Mp3";
			this.rb_Mp3.Size = new System.Drawing.Size(123, 17);
			this.rb_Mp3.TabIndex = 0;
			this.rb_Mp3.TabStop = true;
			this.rb_Mp3.Text = "MPEG Layer 3 (mp3)";
			this.rb_Mp3.UseVisualStyleBackColor = true;
			// 
			// OptionsWindow
			// 
			this.AcceptButton = this.btn_OK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_Cancel;
			this.ClientSize = new System.Drawing.Size(477, 140);
			this.Controls.Add(this.p_Main);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(485, 167);
			this.Name = "OptionsWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Preferences";
			this.p_Main.ResumeLayout(false);
			this.gb_RecordingPath.ResumeLayout(false);
			this.gb_RecordingPath.PerformLayout();
			this.gb_Options.ResumeLayout(false);
			this.gb_Options.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel p_Main;
		private System.Windows.Forms.GroupBox gb_Options;
		private System.Windows.Forms.RadioButton rb_Wav;
		private System.Windows.Forms.RadioButton rb_Mp3;
		private System.Windows.Forms.GroupBox gb_RecordingPath;
		private System.Windows.Forms.Button btn_Browse;
		private System.Windows.Forms.TextBox tb_Browse;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_OK;
		private System.Windows.Forms.FolderBrowserDialog fbd_Browse;
	}
}