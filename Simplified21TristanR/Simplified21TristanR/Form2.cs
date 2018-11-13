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
		SoundPlayer backSound = new SoundPlayer("c:/Casino.wav");
		
		int MIN_CARD = 1;
		int MAX_CARD = 10;
		int BALANCE = 100;
		int card1;
		int card2;
		int card3;
		int dealerCard1;
		int dealerCard2;
		int dealerCard3;
		int dealerCard4;
		int bet;
		

	
		int userChoice;
		int dealerChoice;
	




		public Form2()
		{
			this.btnHit.Hide();
			this.btnDone.Hide();
			this.btnStay.Hide();
			this.btnDoubleDown.Hide();
			

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
			const int STAY = 1;
			const int HIT = 2;
			const int DEALERMINIMUM = 1;
			const int DEALERMAXIMUM = 2;
			int dealerCardTotal;
			int playerCardTotal;
			int userChoice;
			int dealerChoice;
			userChoice = STAY;
			Random rnd = new Random();
			dealerChoice = rnd.Next(DEALERMINIMUM, DEALERMAXIMUM + 1);
			if (dealerChoice == STAY)
			{
				dealerCardTotal = dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;

			}
		}
		private void btnDone_Click(object sender, EventArgs e)
		{
		
		

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

		private void button1_Click(object sender, EventArgs e)
		{
			bet = bet + (int)(this.nudBetAmount.Value);
			card1 = rnd.Next(MIN_CARD, MAX_CARD + 1);
			card2 = rnd.Next(MIN_CARD, MAX_CARD + 1);
			dealerCard1 = rnd.Next(MIN_CARD, MAX_CARD + 1);
			dealerCard2 = rnd.Next(MIN_CARD, MAX_CARD + 1);
			dealerCard3 = rnd.Next(MIN_CARD, MAX_CARD + 1);
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}
	}
}
