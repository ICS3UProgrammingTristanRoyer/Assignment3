using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Simplified21TristanR
{
	public partial class Form2 : Form
	{
		SoundPlayer backSound = new SoundPlayer("c:/.wav");
		Random rnd = new Random();
		int MIN_CARD = 1;
		int MAX_CARD = 10;
		int BALANCE = 100;
		int card1;
		int card2;
		int card3;
		int dealercard1;
		int dealercard2;
		int dealercard3;
		int dealercard4;
		int bet;

		public Form2()
		{
		
			InitializeComponent();
		}

		private void btnHit_Click(object sender, EventArgs e)
		{


		}

		private void btnDoubleDown_Click(object sender, EventArgs e)
		{

		}

		private void btnStay_Click(object sender, EventArgs e)
		{

		}
		private void btnDone_Click(object sender, EventArgs e)
		{
			card1 = rnd.Next(MIN_CARD, MAX_CARD + 1);
			card2 = rnd.Next(MIN_CARD, MAX_CARD + 1);
			dealercard1 = rnd.Next(MIN_CARD, MAX_CARD + 1);
			dealercard2 = rnd.Next(MIN_CARD, MAX_CARD + 1);
			dealercard3 = rnd.Next(MIN_CARD, MAX_CARD + 1);
			if (UserChoice = STAY)
			{ }


		}

		private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			backSound.PlayLooping();
			resumeToolStripMenuItem.Enabled = false;
			muteToolStripMenuItem.Enabled = true;

		}

		private void muteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			backSound.Stop();
			resumeToolStripMenuItem.Enabled = true;
			muteToolStripMenuItem.Enabled = false;

		}
	}
}
