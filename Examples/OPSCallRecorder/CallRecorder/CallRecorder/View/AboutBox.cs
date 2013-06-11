using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CallRecorder.View
{
	partial class AboutBox : Form
	{
		public AboutBox()
		{
			InitializeComponent();
		}

		void LinkLabelWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process.Start("http://ozekiphone.com");
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
		}

		void LinkLabelEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process.Start("mailto://info@ozekiphone.com");
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
		}

		void ButtonOK_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
