using CallRecorder.View.Control;

namespace CallRecorder.View
{
	partial class MainWindow
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.p_Main = new System.Windows.Forms.Panel();
			this.p_Base = new System.Windows.Forms.Panel();
			this.p_Upper = new System.Windows.Forms.Panel();
			this.p_Right = new System.Windows.Forms.Panel();
			this.tc_Recording = new System.Windows.Forms.TabControl();
			this.tp_RecordingDetails = new System.Windows.Forms.TabPage();
			this.lbl_TotalFileSizeValue = new System.Windows.Forms.Label();
			this.lbl_TotalFileSize = new System.Windows.Forms.Label();
			this.lbl_TotalRecordingLengthValue = new System.Windows.Forms.Label();
			this.lbl_TotalRecordingLength = new System.Windows.Forms.Label();
			this.lbl_TotalSavedFilesValue = new System.Windows.Forms.Label();
			this.lbl_TotalSavedFiles = new System.Windows.Forms.Label();
			this.lbl_RecordingPathValue = new System.Windows.Forms.Label();
			this.lbl_RecordingPath = new System.Windows.Forms.Label();
			this.lbl_FormatValue = new System.Windows.Forms.Label();
			this.lbl_Format = new System.Windows.Forms.Label();
			this.lbl_TypeValue = new System.Windows.Forms.Label();
			this.lbl_Type = new System.Windows.Forms.Label();
			this.lbl_StatusValue = new System.Windows.Forms.Label();
			this.lbl_Status = new System.Windows.Forms.Label();
			this.tp_RecordedFiles = new System.Windows.Forms.TabPage();
			this.p_Files = new System.Windows.Forms.Panel();
			this.lv_Files = new CallRecorder.View.Control.ExtendedListView();
			this.ch_0_Filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_1_Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_2_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_3_CallStarted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.il_Images = new System.Windows.Forms.ImageList(this.components);
			this.p_Controls = new System.Windows.Forms.Panel();
			this.btn_DeleteFile = new System.Windows.Forms.Button();
			this.btn_OpenFilesLocation = new System.Windows.Forms.Button();
			this.btn_Play = new System.Windows.Forms.Button();
			this.s_Splitter_2 = new System.Windows.Forms.Splitter();
			this.p_Left = new System.Windows.Forms.Panel();
			this.lv_OutsideLine = new CallRecorder.View.Control.ExtendedListView();
			this.ch_0_OutsideLines = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.s_Splitter = new System.Windows.Forms.Splitter();
			this.lv_Extension = new CallRecorder.View.Control.ExtendedListView();
			this.ch_0_Extensions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.s_Splitter_1 = new System.Windows.Forms.Splitter();
			this.p_Lower = new System.Windows.Forms.Panel();
			this.ss_StatusStrip = new System.Windows.Forms.StatusStrip();
			this.ms_Menu = new System.Windows.Forms.MenuStrip();
			this.tsmi_File = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmi_Manage = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmi_ConnectToServer = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmi_Disconnect = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmi_Preferences = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmi_Help = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmi_OpenOnlineDocumentation = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmi_About = new System.Windows.Forms.ToolStripMenuItem();
			this.t_Timer = new System.Windows.Forms.Timer(this.components);
			this.p_Main.SuspendLayout();
			this.p_Base.SuspendLayout();
			this.p_Upper.SuspendLayout();
			this.p_Right.SuspendLayout();
			this.tc_Recording.SuspendLayout();
			this.tp_RecordingDetails.SuspendLayout();
			this.tp_RecordedFiles.SuspendLayout();
			this.p_Files.SuspendLayout();
			this.p_Controls.SuspendLayout();
			this.p_Left.SuspendLayout();
			this.ms_Menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// p_Main
			// 
			this.p_Main.Controls.Add(this.p_Base);
			this.p_Main.Controls.Add(this.ss_StatusStrip);
			this.p_Main.Controls.Add(this.ms_Menu);
			this.p_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Main.Location = new System.Drawing.Point(0, 0);
			this.p_Main.Name = "p_Main";
			this.p_Main.Size = new System.Drawing.Size(781, 551);
			this.p_Main.TabIndex = 1;
			// 
			// p_Base
			// 
			this.p_Base.Controls.Add(this.p_Upper);
			this.p_Base.Controls.Add(this.s_Splitter_1);
			this.p_Base.Controls.Add(this.p_Lower);
			this.p_Base.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Base.Location = new System.Drawing.Point(0, 24);
			this.p_Base.Name = "p_Base";
			this.p_Base.Size = new System.Drawing.Size(781, 505);
			this.p_Base.TabIndex = 2;
			// 
			// p_Upper
			// 
			this.p_Upper.Controls.Add(this.p_Right);
			this.p_Upper.Controls.Add(this.s_Splitter_2);
			this.p_Upper.Controls.Add(this.p_Left);
			this.p_Upper.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Upper.Location = new System.Drawing.Point(0, 0);
			this.p_Upper.Name = "p_Upper";
			this.p_Upper.Size = new System.Drawing.Size(781, 475);
			this.p_Upper.TabIndex = 2;
			// 
			// p_Right
			// 
			this.p_Right.Controls.Add(this.tc_Recording);
			this.p_Right.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Right.Location = new System.Drawing.Point(234, 0);
			this.p_Right.Name = "p_Right";
			this.p_Right.Size = new System.Drawing.Size(547, 475);
			this.p_Right.TabIndex = 2;
			// 
			// tc_Recording
			// 
			this.tc_Recording.Controls.Add(this.tp_RecordingDetails);
			this.tc_Recording.Controls.Add(this.tp_RecordedFiles);
			this.tc_Recording.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tc_Recording.Location = new System.Drawing.Point(0, 0);
			this.tc_Recording.Name = "tc_Recording";
			this.tc_Recording.SelectedIndex = 0;
			this.tc_Recording.Size = new System.Drawing.Size(547, 475);
			this.tc_Recording.TabIndex = 0;
			// 
			// tp_RecordingDetails
			// 
			this.tp_RecordingDetails.Controls.Add(this.lbl_TotalFileSizeValue);
			this.tp_RecordingDetails.Controls.Add(this.lbl_TotalFileSize);
			this.tp_RecordingDetails.Controls.Add(this.lbl_TotalRecordingLengthValue);
			this.tp_RecordingDetails.Controls.Add(this.lbl_TotalRecordingLength);
			this.tp_RecordingDetails.Controls.Add(this.lbl_TotalSavedFilesValue);
			this.tp_RecordingDetails.Controls.Add(this.lbl_TotalSavedFiles);
			this.tp_RecordingDetails.Controls.Add(this.lbl_RecordingPathValue);
			this.tp_RecordingDetails.Controls.Add(this.lbl_RecordingPath);
			this.tp_RecordingDetails.Controls.Add(this.lbl_FormatValue);
			this.tp_RecordingDetails.Controls.Add(this.lbl_Format);
			this.tp_RecordingDetails.Controls.Add(this.lbl_TypeValue);
			this.tp_RecordingDetails.Controls.Add(this.lbl_Type);
			this.tp_RecordingDetails.Controls.Add(this.lbl_StatusValue);
			this.tp_RecordingDetails.Controls.Add(this.lbl_Status);
			this.tp_RecordingDetails.Location = new System.Drawing.Point(4, 22);
			this.tp_RecordingDetails.Name = "tp_RecordingDetails";
			this.tp_RecordingDetails.Padding = new System.Windows.Forms.Padding(3);
			this.tp_RecordingDetails.Size = new System.Drawing.Size(539, 449);
			this.tp_RecordingDetails.TabIndex = 0;
			this.tp_RecordingDetails.Text = "Recording details";
			this.tp_RecordingDetails.UseVisualStyleBackColor = true;
			// 
			// lbl_TotalFileSizeValue
			// 
			this.lbl_TotalFileSizeValue.AutoSize = true;
			this.lbl_TotalFileSizeValue.Location = new System.Drawing.Point(141, 161);
			this.lbl_TotalFileSizeValue.Name = "lbl_TotalFileSizeValue";
			this.lbl_TotalFileSizeValue.Size = new System.Drawing.Size(27, 13);
			this.lbl_TotalFileSizeValue.TabIndex = 13;
			this.lbl_TotalFileSizeValue.Text = "N/A";
			// 
			// lbl_TotalFileSize
			// 
			this.lbl_TotalFileSize.AutoSize = true;
			this.lbl_TotalFileSize.Location = new System.Drawing.Point(16, 161);
			this.lbl_TotalFileSize.Name = "lbl_TotalFileSize";
			this.lbl_TotalFileSize.Size = new System.Drawing.Size(93, 13);
			this.lbl_TotalFileSize.TabIndex = 12;
			this.lbl_TotalFileSize.Text = "Total file size (MB)";
			// 
			// lbl_TotalRecordingLengthValue
			// 
			this.lbl_TotalRecordingLengthValue.AutoSize = true;
			this.lbl_TotalRecordingLengthValue.Location = new System.Drawing.Point(141, 136);
			this.lbl_TotalRecordingLengthValue.Name = "lbl_TotalRecordingLengthValue";
			this.lbl_TotalRecordingLengthValue.Size = new System.Drawing.Size(27, 13);
			this.lbl_TotalRecordingLengthValue.TabIndex = 11;
			this.lbl_TotalRecordingLengthValue.Text = "N/A";
			// 
			// lbl_TotalRecordingLength
			// 
			this.lbl_TotalRecordingLength.AutoSize = true;
			this.lbl_TotalRecordingLength.Location = new System.Drawing.Point(16, 136);
			this.lbl_TotalRecordingLength.Name = "lbl_TotalRecordingLength";
			this.lbl_TotalRecordingLength.Size = new System.Drawing.Size(110, 13);
			this.lbl_TotalRecordingLength.TabIndex = 10;
			this.lbl_TotalRecordingLength.Text = "Total recording length";
			// 
			// lbl_TotalSavedFilesValue
			// 
			this.lbl_TotalSavedFilesValue.AutoSize = true;
			this.lbl_TotalSavedFilesValue.Location = new System.Drawing.Point(141, 112);
			this.lbl_TotalSavedFilesValue.Name = "lbl_TotalSavedFilesValue";
			this.lbl_TotalSavedFilesValue.Size = new System.Drawing.Size(27, 13);
			this.lbl_TotalSavedFilesValue.TabIndex = 9;
			this.lbl_TotalSavedFilesValue.Text = "N/A";
			// 
			// lbl_TotalSavedFiles
			// 
			this.lbl_TotalSavedFiles.AutoSize = true;
			this.lbl_TotalSavedFiles.Location = new System.Drawing.Point(16, 112);
			this.lbl_TotalSavedFiles.Name = "lbl_TotalSavedFiles";
			this.lbl_TotalSavedFiles.Size = new System.Drawing.Size(84, 13);
			this.lbl_TotalSavedFiles.TabIndex = 8;
			this.lbl_TotalSavedFiles.Text = "Total saved files";
			// 
			// lbl_RecordingPathValue
			// 
			this.lbl_RecordingPathValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_RecordingPathValue.AutoSize = true;
			this.lbl_RecordingPathValue.Location = new System.Drawing.Point(141, 424);
			this.lbl_RecordingPathValue.Name = "lbl_RecordingPathValue";
			this.lbl_RecordingPathValue.Size = new System.Drawing.Size(90, 13);
			this.lbl_RecordingPathValue.TabIndex = 7;
			this.lbl_RecordingPathValue.Text = "C:\\RecordedFiles";
			// 
			// lbl_RecordingPath
			// 
			this.lbl_RecordingPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_RecordingPath.AutoSize = true;
			this.lbl_RecordingPath.Location = new System.Drawing.Point(16, 424);
			this.lbl_RecordingPath.Name = "lbl_RecordingPath";
			this.lbl_RecordingPath.Size = new System.Drawing.Size(80, 13);
			this.lbl_RecordingPath.TabIndex = 6;
			this.lbl_RecordingPath.Text = "Recording path";
			// 
			// lbl_FormatValue
			// 
			this.lbl_FormatValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_FormatValue.AutoSize = true;
			this.lbl_FormatValue.Location = new System.Drawing.Point(141, 399);
			this.lbl_FormatValue.Name = "lbl_FormatValue";
			this.lbl_FormatValue.Size = new System.Drawing.Size(29, 13);
			this.lbl_FormatValue.TabIndex = 5;
			this.lbl_FormatValue.Text = "MP3";
			// 
			// lbl_Format
			// 
			this.lbl_Format.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_Format.AutoSize = true;
			this.lbl_Format.Location = new System.Drawing.Point(16, 399);
			this.lbl_Format.Name = "lbl_Format";
			this.lbl_Format.Size = new System.Drawing.Size(88, 13);
			this.lbl_Format.TabIndex = 4;
			this.lbl_Format.Text = "Recording format";
			// 
			// lbl_TypeValue
			// 
			this.lbl_TypeValue.AutoSize = true;
			this.lbl_TypeValue.Location = new System.Drawing.Point(141, 37);
			this.lbl_TypeValue.Name = "lbl_TypeValue";
			this.lbl_TypeValue.Size = new System.Drawing.Size(27, 13);
			this.lbl_TypeValue.TabIndex = 3;
			this.lbl_TypeValue.Text = "N/A";
			// 
			// lbl_Type
			// 
			this.lbl_Type.AutoSize = true;
			this.lbl_Type.Location = new System.Drawing.Point(16, 37);
			this.lbl_Type.Name = "lbl_Type";
			this.lbl_Type.Size = new System.Drawing.Size(31, 13);
			this.lbl_Type.TabIndex = 2;
			this.lbl_Type.Text = "Type";
			// 
			// lbl_StatusValue
			// 
			this.lbl_StatusValue.AutoSize = true;
			this.lbl_StatusValue.Location = new System.Drawing.Point(141, 13);
			this.lbl_StatusValue.Name = "lbl_StatusValue";
			this.lbl_StatusValue.Size = new System.Drawing.Size(27, 13);
			this.lbl_StatusValue.TabIndex = 1;
			this.lbl_StatusValue.Text = "N/A";
			// 
			// lbl_Status
			// 
			this.lbl_Status.AutoSize = true;
			this.lbl_Status.Location = new System.Drawing.Point(16, 13);
			this.lbl_Status.Name = "lbl_Status";
			this.lbl_Status.Size = new System.Drawing.Size(37, 13);
			this.lbl_Status.TabIndex = 0;
			this.lbl_Status.Text = "Status";
			// 
			// tp_RecordedFiles
			// 
			this.tp_RecordedFiles.Controls.Add(this.p_Files);
			this.tp_RecordedFiles.Controls.Add(this.p_Controls);
			this.tp_RecordedFiles.Location = new System.Drawing.Point(4, 22);
			this.tp_RecordedFiles.Name = "tp_RecordedFiles";
			this.tp_RecordedFiles.Padding = new System.Windows.Forms.Padding(3);
			this.tp_RecordedFiles.Size = new System.Drawing.Size(539, 449);
			this.tp_RecordedFiles.TabIndex = 1;
			this.tp_RecordedFiles.Text = "Recorded files";
			this.tp_RecordedFiles.UseVisualStyleBackColor = true;
			// 
			// p_Files
			// 
			this.p_Files.Controls.Add(this.lv_Files);
			this.p_Files.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Files.Location = new System.Drawing.Point(3, 3);
			this.p_Files.Name = "p_Files";
			this.p_Files.Size = new System.Drawing.Size(533, 404);
			this.p_Files.TabIndex = 1;
			// 
			// lv_Files
			// 
			this.lv_Files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_0_Filename,
            this.ch_1_Duration,
            this.ch_2_Size,
            this.ch_3_CallStarted});
			this.lv_Files.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lv_Files.EvenRowColor = System.Drawing.Color.Aquamarine;
			this.lv_Files.FullRowSelect = true;
			this.lv_Files.Location = new System.Drawing.Point(0, 0);
			this.lv_Files.MultiSelect = false;
			this.lv_Files.Name = "lv_Files";
			this.lv_Files.OddRowColor = System.Drawing.SystemColors.Window;
			this.lv_Files.OwnerDraw = true;
			this.lv_Files.Size = new System.Drawing.Size(533, 404);
			this.lv_Files.SmallImageList = this.il_Images;
			this.lv_Files.TabIndex = 0;
			this.lv_Files.UseAlternatingColors = true;
			this.lv_Files.UseCompatibleStateImageBehavior = false;
			this.lv_Files.View = System.Windows.Forms.View.Details;
			// 
			// ch_0_Filename
			// 
			this.ch_0_Filename.Text = "Filename";
			this.ch_0_Filename.Width = 256;
			// 
			// ch_1_Duration
			// 
			this.ch_1_Duration.Text = "Duration";
			this.ch_1_Duration.Width = 64;
			// 
			// ch_2_Size
			// 
			this.ch_2_Size.Text = "Size (MB)";
			this.ch_2_Size.Width = 89;
			// 
			// ch_3_CallStarted
			// 
			this.ch_3_CallStarted.Text = "Call started";
			this.ch_3_CallStarted.Width = 117;
			// 
			// il_Images
			// 
			this.il_Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_Images.ImageStream")));
			this.il_Images.TransparentColor = System.Drawing.Color.Transparent;
			this.il_Images.Images.SetKeyName(0, "record.ico");
			this.il_Images.Images.SetKeyName(1, "no_record.ico");
			this.il_Images.Images.SetKeyName(2, "piano.png");
			// 
			// p_Controls
			// 
			this.p_Controls.Controls.Add(this.btn_DeleteFile);
			this.p_Controls.Controls.Add(this.btn_OpenFilesLocation);
			this.p_Controls.Controls.Add(this.btn_Play);
			this.p_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.p_Controls.Location = new System.Drawing.Point(3, 407);
			this.p_Controls.Name = "p_Controls";
			this.p_Controls.Size = new System.Drawing.Size(533, 39);
			this.p_Controls.TabIndex = 0;
			// 
			// btn_DeleteFile
			// 
			this.btn_DeleteFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_DeleteFile.Location = new System.Drawing.Point(314, 6);
			this.btn_DeleteFile.Name = "btn_DeleteFile";
			this.btn_DeleteFile.Size = new System.Drawing.Size(104, 25);
			this.btn_DeleteFile.TabIndex = 1;
			this.btn_DeleteFile.Text = "Delete file";
			this.btn_DeleteFile.UseVisualStyleBackColor = true;
			this.btn_DeleteFile.Click += new System.EventHandler(this.btn_DeleteFile_Click);
			// 
			// btn_OpenFilesLocation
			// 
			this.btn_OpenFilesLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_OpenFilesLocation.Location = new System.Drawing.Point(424, 6);
			this.btn_OpenFilesLocation.Name = "btn_OpenFilesLocation";
			this.btn_OpenFilesLocation.Size = new System.Drawing.Size(104, 25);
			this.btn_OpenFilesLocation.TabIndex = 2;
			this.btn_OpenFilesLocation.Text = "Open files location";
			this.btn_OpenFilesLocation.UseVisualStyleBackColor = true;
			this.btn_OpenFilesLocation.Click += new System.EventHandler(this.btn_OpenFilesLocation_Click);
			// 
			// btn_Play
			// 
			this.btn_Play.Image = global::CallRecorder.Properties.Resources.control_play;
			this.btn_Play.Location = new System.Drawing.Point(3, 6);
			this.btn_Play.Name = "btn_Play";
			this.btn_Play.Size = new System.Drawing.Size(25, 25);
			this.btn_Play.TabIndex = 0;
			this.btn_Play.UseVisualStyleBackColor = true;
			this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
			// 
			// s_Splitter_2
			// 
			this.s_Splitter_2.Location = new System.Drawing.Point(231, 0);
			this.s_Splitter_2.Name = "s_Splitter_2";
			this.s_Splitter_2.Size = new System.Drawing.Size(3, 475);
			this.s_Splitter_2.TabIndex = 1;
			this.s_Splitter_2.TabStop = false;
			// 
			// p_Left
			// 
			this.p_Left.Controls.Add(this.lv_OutsideLine);
			this.p_Left.Controls.Add(this.s_Splitter);
			this.p_Left.Controls.Add(this.lv_Extension);
			this.p_Left.Dock = System.Windows.Forms.DockStyle.Left;
			this.p_Left.Location = new System.Drawing.Point(0, 0);
			this.p_Left.Name = "p_Left";
			this.p_Left.Size = new System.Drawing.Size(231, 475);
			this.p_Left.TabIndex = 0;
			// 
			// lv_OutsideLine
			// 
			this.lv_OutsideLine.CheckBoxes = true;
			this.lv_OutsideLine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_0_OutsideLines});
			this.lv_OutsideLine.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lv_OutsideLine.EvenRowColor = System.Drawing.Color.LightBlue;
			this.lv_OutsideLine.FullRowSelect = true;
			this.lv_OutsideLine.Location = new System.Drawing.Point(0, 244);
			this.lv_OutsideLine.Name = "lv_OutsideLine";
			this.lv_OutsideLine.OddRowColor = System.Drawing.SystemColors.Window;
			this.lv_OutsideLine.OwnerDraw = true;
			this.lv_OutsideLine.Size = new System.Drawing.Size(231, 231);
			this.lv_OutsideLine.SmallImageList = this.il_Images;
			this.lv_OutsideLine.TabIndex = 1;
			this.lv_OutsideLine.UseAlternatingColors = true;
			this.lv_OutsideLine.UseCompatibleStateImageBehavior = false;
			this.lv_OutsideLine.View = System.Windows.Forms.View.Details;
			this.lv_OutsideLine.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lv_Extension_ItemChecked);
			this.lv_OutsideLine.SelectedIndexChanged += new System.EventHandler(this.lv_OutsideLine_SelectedIndexChanged);
			// 
			// ch_0_OutsideLines
			// 
			this.ch_0_OutsideLines.Text = "Outside lines";
			this.ch_0_OutsideLines.Width = 227;
			// 
			// s_Splitter
			// 
			this.s_Splitter.Dock = System.Windows.Forms.DockStyle.Top;
			this.s_Splitter.Location = new System.Drawing.Point(0, 241);
			this.s_Splitter.Name = "s_Splitter";
			this.s_Splitter.Size = new System.Drawing.Size(231, 3);
			this.s_Splitter.TabIndex = 1;
			this.s_Splitter.TabStop = false;
			// 
			// lv_Extension
			// 
			this.lv_Extension.CheckBoxes = true;
			this.lv_Extension.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_0_Extensions});
			this.lv_Extension.Dock = System.Windows.Forms.DockStyle.Top;
			this.lv_Extension.EvenRowColor = System.Drawing.Color.LightBlue;
			this.lv_Extension.FullRowSelect = true;
			this.lv_Extension.Location = new System.Drawing.Point(0, 0);
			this.lv_Extension.Name = "lv_Extension";
			this.lv_Extension.OddRowColor = System.Drawing.SystemColors.Window;
			this.lv_Extension.OwnerDraw = true;
			this.lv_Extension.Size = new System.Drawing.Size(231, 241);
			this.lv_Extension.SmallImageList = this.il_Images;
			this.lv_Extension.TabIndex = 0;
			this.lv_Extension.UseAlternatingColors = true;
			this.lv_Extension.UseCompatibleStateImageBehavior = false;
			this.lv_Extension.View = System.Windows.Forms.View.Details;
			this.lv_Extension.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lv_Extension_ItemChecked);
			this.lv_Extension.SelectedIndexChanged += new System.EventHandler(this.lv_Extension_SelectedIndexChanged);
			// 
			// ch_0_Extensions
			// 
			this.ch_0_Extensions.Text = "Extensions";
			this.ch_0_Extensions.Width = 227;
			// 
			// s_Splitter_1
			// 
			this.s_Splitter_1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.s_Splitter_1.Location = new System.Drawing.Point(0, 475);
			this.s_Splitter_1.Name = "s_Splitter_1";
			this.s_Splitter_1.Size = new System.Drawing.Size(781, 3);
			this.s_Splitter_1.TabIndex = 2;
			this.s_Splitter_1.TabStop = false;
			// 
			// p_Lower
			// 
			this.p_Lower.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.p_Lower.Location = new System.Drawing.Point(0, 478);
			this.p_Lower.Name = "p_Lower";
			this.p_Lower.Size = new System.Drawing.Size(781, 27);
			this.p_Lower.TabIndex = 0;
			this.p_Lower.Visible = false;
			// 
			// ss_StatusStrip
			// 
			this.ss_StatusStrip.Location = new System.Drawing.Point(0, 529);
			this.ss_StatusStrip.Name = "ss_StatusStrip";
			this.ss_StatusStrip.Size = new System.Drawing.Size(781, 22);
			this.ss_StatusStrip.TabIndex = 1;
			this.ss_StatusStrip.Text = "statusStrip1";
			// 
			// ms_Menu
			// 
			this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_File,
            this.tsmi_Manage,
            this.tsmi_Preferences,
            this.tsmi_Help});
			this.ms_Menu.Location = new System.Drawing.Point(0, 0);
			this.ms_Menu.Name = "ms_Menu";
			this.ms_Menu.Size = new System.Drawing.Size(781, 24);
			this.ms_Menu.TabIndex = 0;
			this.ms_Menu.Text = "menuStrip1";
			// 
			// tsmi_File
			// 
			this.tsmi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Exit});
			this.tsmi_File.Image = global::CallRecorder.Properties.Resources.page_2;
			this.tsmi_File.Name = "tsmi_File";
			this.tsmi_File.Size = new System.Drawing.Size(51, 20);
			this.tsmi_File.Text = "File";
			// 
			// tsmi_Exit
			// 
			this.tsmi_Exit.Image = global::CallRecorder.Properties.Resources.door_in;
			this.tsmi_Exit.Name = "tsmi_Exit";
			this.tsmi_Exit.Size = new System.Drawing.Size(92, 22);
			this.tsmi_Exit.Text = "Exit";
			this.tsmi_Exit.Click += new System.EventHandler(this.tsmi_Exit_Click);
			// 
			// tsmi_Manage
			// 
			this.tsmi_Manage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_ConnectToServer,
            this.tsmi_Disconnect});
			this.tsmi_Manage.Image = global::CallRecorder.Properties.Resources.computer;
			this.tsmi_Manage.Name = "tsmi_Manage";
			this.tsmi_Manage.Size = new System.Drawing.Size(73, 20);
			this.tsmi_Manage.Text = "Manage";
			// 
			// tsmi_ConnectToServer
			// 
			this.tsmi_ConnectToServer.Image = global::CallRecorder.Properties.Resources.connect;
			this.tsmi_ConnectToServer.Name = "tsmi_ConnectToServer";
			this.tsmi_ConnectToServer.Size = new System.Drawing.Size(161, 22);
			this.tsmi_ConnectToServer.Text = "Connect to server";
			this.tsmi_ConnectToServer.Click += new System.EventHandler(this.tsmi_ConnectToServer_Click);
			// 
			// tsmi_Disconnect
			// 
			this.tsmi_Disconnect.Image = global::CallRecorder.Properties.Resources.disconnect;
			this.tsmi_Disconnect.Name = "tsmi_Disconnect";
			this.tsmi_Disconnect.Size = new System.Drawing.Size(161, 22);
			this.tsmi_Disconnect.Text = "Disconnect";
			this.tsmi_Disconnect.Click += new System.EventHandler(this.tsmi_Disconnect_Click);
			// 
			// tsmi_Preferences
			// 
			this.tsmi_Preferences.Image = global::CallRecorder.Properties.Resources.cog;
			this.tsmi_Preferences.Name = "tsmi_Preferences";
			this.tsmi_Preferences.Size = new System.Drawing.Size(93, 20);
			this.tsmi_Preferences.Text = "Preferences";
			this.tsmi_Preferences.Click += new System.EventHandler(this.tsmi_Preferences_Click);
			// 
			// tsmi_Help
			// 
			this.tsmi_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_OpenOnlineDocumentation,
            this.tsmi_About});
			this.tsmi_Help.Image = global::CallRecorder.Properties.Resources.help;
			this.tsmi_Help.Name = "tsmi_Help";
			this.tsmi_Help.Size = new System.Drawing.Size(56, 20);
			this.tsmi_Help.Text = "Help";
			// 
			// tsmi_OpenOnlineDocumentation
			// 
			this.tsmi_OpenOnlineDocumentation.Image = global::CallRecorder.Properties.Resources.page_white_text;
			this.tsmi_OpenOnlineDocumentation.Name = "tsmi_OpenOnlineDocumentation";
			this.tsmi_OpenOnlineDocumentation.Size = new System.Drawing.Size(205, 22);
			this.tsmi_OpenOnlineDocumentation.Text = "Open online documentation";
			this.tsmi_OpenOnlineDocumentation.Click += new System.EventHandler(this.tsmi_OpenOnlineDocumentation_Click);
			// 
			// tsmi_About
			// 
			this.tsmi_About.Image = global::CallRecorder.Properties.Resources.exclamation;
			this.tsmi_About.Name = "tsmi_About";
			this.tsmi_About.Size = new System.Drawing.Size(205, 22);
			this.tsmi_About.Text = "About";
			this.tsmi_About.Click += new System.EventHandler(this.tsmi_About_Click);
			// 
			// t_Timer
			// 
			this.t_Timer.Enabled = true;
			this.t_Timer.Interval = 1000;
			this.t_Timer.Tick += new System.EventHandler(this.t_Timer_Tick);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(781, 551);
			this.Controls.Add(this.p_Main);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(546, 578);
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Call Recorder";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			this.p_Main.ResumeLayout(false);
			this.p_Main.PerformLayout();
			this.p_Base.ResumeLayout(false);
			this.p_Upper.ResumeLayout(false);
			this.p_Right.ResumeLayout(false);
			this.tc_Recording.ResumeLayout(false);
			this.tp_RecordingDetails.ResumeLayout(false);
			this.tp_RecordingDetails.PerformLayout();
			this.tp_RecordedFiles.ResumeLayout(false);
			this.p_Files.ResumeLayout(false);
			this.p_Controls.ResumeLayout(false);
			this.p_Left.ResumeLayout(false);
			this.ms_Menu.ResumeLayout(false);
			this.ms_Menu.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel p_Main;
		private System.Windows.Forms.Panel p_Base;
		private System.Windows.Forms.Panel p_Upper;
		private System.Windows.Forms.Panel p_Right;
		private System.Windows.Forms.TabControl tc_Recording;
		private System.Windows.Forms.TabPage tp_RecordingDetails;
		private System.Windows.Forms.TabPage tp_RecordedFiles;
		private System.Windows.Forms.Splitter s_Splitter_2;
		private System.Windows.Forms.Panel p_Left;
		private System.Windows.Forms.Splitter s_Splitter_1;
		private System.Windows.Forms.Panel p_Lower;
		private System.Windows.Forms.StatusStrip ss_StatusStrip;
		private System.Windows.Forms.MenuStrip ms_Menu;
		private System.Windows.Forms.ToolStripMenuItem tsmi_File;
		private System.Windows.Forms.ToolStripMenuItem tsmi_Exit;
		private System.Windows.Forms.ToolStripMenuItem tsmi_Manage;
		private System.Windows.Forms.ToolStripMenuItem tsmi_ConnectToServer;
		private System.Windows.Forms.ToolStripMenuItem tsmi_Disconnect;
		private System.Windows.Forms.ToolStripMenuItem tsmi_Help;
		private System.Windows.Forms.ToolStripMenuItem tsmi_OpenOnlineDocumentation;
		private System.Windows.Forms.ToolStripMenuItem tsmi_About;
		private ExtendedListView lv_OutsideLine;
		private System.Windows.Forms.Splitter s_Splitter;
		private ExtendedListView lv_Extension;
		private System.Windows.Forms.Label lbl_TypeValue;
		private System.Windows.Forms.Label lbl_Type;
		private System.Windows.Forms.Label lbl_StatusValue;
		private System.Windows.Forms.Label lbl_Status;
		private System.Windows.Forms.Panel p_Files;
		private ExtendedListView lv_Files;
		private System.Windows.Forms.Panel p_Controls;
		private System.Windows.Forms.Label lbl_RecordingPathValue;
		private System.Windows.Forms.Label lbl_RecordingPath;
		private System.Windows.Forms.Label lbl_FormatValue;
		private System.Windows.Forms.Label lbl_Format;
		private System.Windows.Forms.Label lbl_TotalFileSizeValue;
		private System.Windows.Forms.Label lbl_TotalFileSize;
		private System.Windows.Forms.Label lbl_TotalRecordingLengthValue;
		private System.Windows.Forms.Label lbl_TotalRecordingLength;
		private System.Windows.Forms.Label lbl_TotalSavedFilesValue;
		private System.Windows.Forms.Label lbl_TotalSavedFiles;
		private System.Windows.Forms.ToolStripMenuItem tsmi_Preferences;
		private System.Windows.Forms.ColumnHeader ch_0_OutsideLines;
		private System.Windows.Forms.ColumnHeader ch_0_Extensions;
		private System.Windows.Forms.Button btn_DeleteFile;
		private System.Windows.Forms.Button btn_OpenFilesLocation;
		private System.Windows.Forms.Button btn_Play;
		private System.Windows.Forms.ImageList il_Images;
		private System.Windows.Forms.Timer t_Timer;
		private System.Windows.Forms.ColumnHeader ch_0_Filename;
		private System.Windows.Forms.ColumnHeader ch_1_Duration;
		private System.Windows.Forms.ColumnHeader ch_2_Size;
		private System.Windows.Forms.ColumnHeader ch_3_CallStarted;
	}
}

