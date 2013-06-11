using System.Drawing;
using System.Windows.Forms;

namespace CallRecorder.View.Control
{
	class ExtendedListView : ListView
	{
		public bool UseAlternatingColors { get; set; }
		public Color OddRowColor { get; set; }
		public Color EvenRowColor { get; set; }

		protected override void OnNotifyMessage(Message m)
		{
			if (m.Msg != 0x0014)
				base.OnNotifyMessage(m);
		}

		protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
		{
			base.OnDrawColumnHeader(e);
			e.DrawDefault = true;
		}

		protected override void OnDrawItem(DrawListViewItemEventArgs e)
		{
			if (!UseAlternatingColors) base.OnDrawItem(e);
			else e.Item.BackColor = e.ItemIndex % 2 == 0 ? OddRowColor : EvenRowColor;
				
			e.DrawDefault = true;
		}

		public ExtendedListView()
		{
			OddRowColor = base.BackColor;
			EvenRowColor = Color.LightBlue;
			FullRowSelect = true;
			View = System.Windows.Forms.View.Details;
			UseAlternatingColors = true;

			OwnerDraw = UseAlternatingColors;
			SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.EnableNotifyMessage, true);
		}
	}
}
