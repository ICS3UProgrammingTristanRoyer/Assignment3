/*
 * Created by: Tristan Royer
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Assignment #6b - Simplified 21
 * This program allows you to play a very simplified version of blackjack.
*/
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
using System.Threading;

namespace Simplified21TristanR
{
	public partial class BlackJack : Form
	{
		System.Media.SoundPlayer backSound = new System.Media.SoundPlayer();
	
		
		int MIN_CARD = 1;
		int MAX_CARD = 10;
		int balance = 100;
		int card1;
		int card2;
		int card3;
		int dealerCard1;
		int dealerCard2;
		int dealerCard3;
		int dealerCard4;
		double bet;
		int playerCardTotal;
		int dealerCardTotal;
		double Earnings;
		int intearnings;

		Random rnd = new Random();
		








	public BlackJack()
		{

			backSound.SoundLocation = "Casino.wav";
		





			InitializeComponent();
			lblBalance.Text = "CA$100";
			this.btnHit.Hide();
			this.btnStay.Hide();
			this.btnDoubleDown.Hide();
			this.lblCard1.Hide();
			this.lblCard2.Hide();
			this.lblCard3.Hide();
			this.lblDealerCard1.Hide();
			this.lblDealerCard2.Hide();
			this.lblDealerCard3.Hide();
			this.lblDealerCard4.Hide();
			this.lblDealerTotal.Hide();
			


			backSound.PlayLooping();
			resumeToolStripMenuItem.Enabled = false;
			muteToolStripMenuItem.Enabled = true;
		    

		}


		private void btnHit_Click(object sender, EventArgs e)
		{
			const int STAY = 1;
			const int HIT = 2;
			const int DEALERMINIMUM = 1;
			const int DEALERMAXIMUM = 2;
			int dealerChoice;
			card3 = rnd.Next(MIN_CARD, MAX_CARD + 1);
			playerCardTotal = card1 + card2 + card3;
			this.lblCard3.Show();
			dealerCardTotal = 0;
			lblPlayerTotal.Text = "Player Total:" + playerCardTotal;
			dealerChoice = rnd.Next(DEALERMINIMUM, DEALERMAXIMUM + 1);
			if (dealerChoice == STAY)
			{
				dealerCard4 = 0;
				dealerCardTotal = dealerCardTotal + dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
				lblDealerTotal.Text = "Dealer Total:" + dealerCardTotal;
			}
			else if (dealerChoice == HIT)
			{
				dealerCard4 = rnd.Next(MIN_CARD, MAX_CARD + 1);
				dealerCardTotal = dealerCardTotal + dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
				lblDealerTotal.Text = "Dealer Total:" + dealerCardTotal;
				lblDealerCard4.Text = " " + dealerCard4;
				lblDealerCard4.Show();

			}
			lblDealerCard1.Show();
			lblDealerCard2.Show();
			lblDealerCard3.Show();
			this.btnHit.Hide();
			this.btnStay.Hide();
			this.btnDoubleDown.Hide();
			if (playerCardTotal > 21)
			{
				lblWinner.Text = "you Lose";
			}
			else if (dealerCardTotal > 21)
			{
				lblWinner.Text = "you win";
				balance = Earnings + balance;
			}
			else if (playerCardTotal == dealerCardTotal)
			{
				lblWinner.Text = "You tied , dealer wins.";

			}
			else if (playerCardTotal > dealerCardTotal)
			{
				lblWinner.Text = "you win";
				balance = balance + Earnings;

			}
			else if (playerCardTotal < dealerCardTotal)
			{
				lblWinner.Text = "you Lose";
			}
			lblBalance.Text = String.Format("CA${0:0.00}", balance);

			if (playerCardTotal == 21)
			{
				lblBlackjack.Text = "BLACKJACK!";
			}




		}

		private void btnDoubleDown_Click(object sender, EventArgs e)
		{
			const int STAY = 1;
			const int HIT = 2;
			const int DEALERMINIMUM = 1;
			const int DEALERMAXIMUM = 2;
			int dealerChoice;
			if (balance >= bet)
			{
				bet = bet * 2;
				card3 = rnd.Next(MIN_CARD, MAX_CARD + 1);
				playerCardTotal = card1 + card2 + card3;
				this.lblCard3.Show();
				dealerCardTotal = 0;
				lblPlayerTotal.Text = "Player Total:" + playerCardTotal;
				dealerChoice = rnd.Next(DEALERMINIMUM, DEALERMAXIMUM + 1);
				if (dealerChoice == STAY)
				{
					dealerCard4 = 0;
					dealerCardTotal = dealerCardTotal + dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
					lblDealerTotal.Text = "Dealer Total:" + dealerCardTotal;
				}
				else if (dealerChoice == HIT)
				{
					dealerCard4 = rnd.Next(MIN_CARD, MAX_CARD + 1);
					dealerCardTotal = dealerCardTotal + dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
					lblDealerTotal.Text = "Dealer Total:" + dealerCardTotal;
					lblDealerCard4.Text = " " + dealerCard4;
					lblDealerCard4.Show();

				}
				lblDealerCard1.Show();
				lblDealerCard2.Show();
				lblDealerCard3.Show();
				this.btnHit.Hide();
				this.btnStay.Hide();
				this.btnDoubleDown.Hide();
				if (playerCardTotal > 21)
				{
					lblWinner.Text = "you Lose";
				}
				else if (dealerCardTotal > 21)
				{
					lblWinner.Text = "you win";
					balance = Earnings + balance;
				}
				else if (playerCardTotal == dealerCardTotal)
				{
					lblWinner.Text = "You tied , dealer wins.";

				}
				else if (playerCardTotal > dealerCardTotal)
				{
					lblWinner.Text = "you win";
					balance = balance + Earnings;

				}
				else if (playerCardTotal < dealerCardTotal)
				{
					lblWinner.Text = "you Lose";
				}
				lblBalance.Text = String.Format("CA${0:0.00}", balance);

				if (playerCardTotal == 21)
				{
					lblBlackjack.Text = "BLACKJACK!";
				}
			}
			else
			{
				lblError.Text = "Insufficient funds";
			}

		}

		private void btnStay_Click(object sender, EventArgs e)
		{
			const int STAY = 1;
			const int HIT = 2;
			const int DEALERMINIMUM = 1;
			const int DEALERMAXIMUM = 2;
			int dealerChoice;
			card3 = 0;
			playerCardTotal = card1 + card2 + card3;
			dealerCardTotal = 0;
			lblPlayerTotal.Text = "Player Total:" + playerCardTotal;
			dealerChoice = rnd.Next(DEALERMINIMUM, DEALERMAXIMUM + 1);
			if (dealerChoice == STAY)
			{
				dealerCard4 = 0;
				dealerCardTotal = dealerCardTotal + dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
				lblDealerTotal.Text = "Dealer Total:" + dealerCardTotal;
			}
			else if (dealerChoice == HIT)
			{
				dealerCard4 = rnd.Next(MIN_CARD, MAX_CARD + 1);
				dealerCardTotal = dealerCardTotal + dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
				lblDealerTotal.Text = "Dealer Total:" + dealerCardTotal;
				lblDealerCard4.Text = " " + dealerCard4;
				lblDealerCard4.Show();

			}
			lblDealerCard1.Show();
			lblDealerCard2.Show();
			lblDealerCard3.Show();
			this.btnHit.Hide();
			this.btnStay.Hide();
			this.btnDoubleDown.Hide();
			if (playerCardTotal > 21)
			{
				lblWinner.Text = "you Lose";
			}
			else if (dealerCardTotal > 21)
			{
				lblWinner.Text = "you win";
				balance = Earnings + balance;
			}
			else if (playerCardTotal == dealerCardTotal)
			{
				lblWinner.Text = "You tied , dealer wins.";
				
			}
			else if (playerCardTotal > dealerCardTotal)
			{
				lblWinner.Text = "you win";
				balance = balance + Earnings;
				
			}
			else if (playerCardTotal < dealerCardTotal)
			{
				lblWinner.Text = "you Lose";
			}
			lblBalance.Text = String.Format("CA${0:0.00}", balance);

			if (playerCardTotal == 21)
			{
				lblBlackjack.Text = "BLACKJACK!";
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
		

			if (this.nudBetAmount.Value <= balance)
			{
			
				bet = bet + (int)(this.nudBetAmount.Value);
				balance = balance - bet;
				card1 = rnd.Next(MIN_CARD, MAX_CARD + 1);
				card2 = rnd.Next(MIN_CARD, MAX_CARD + 1);
				lblCard1.Text = " " + card1;
				lblCard2.Text = " " + card2;
 				dealerCard1 = rnd.Next(MIN_CARD, MAX_CARD + 1);
				dealerCard2 = rnd.Next(MIN_CARD, MAX_CARD + 1);
				dealerCard3 = rnd.Next(MIN_CARD, MAX_CARD + 1);
				lblDealerCard1.Text = " " + dealerCard1;
				lblDealerCard2.Text = " " + dealerCard2;
				lblDealerCard3.Text = " " + dealerCard3;


				this.lblCard1.Show();
				this.lblCard2.Show();
<<<<<<< HEAD
<<<<<<< HEAD
				// shows the buttons for the user's options.
=======
				this.lblCard3.Show();
>>>>>>> parent of da8303b... done
=======
				this.lblCard3.Show();
>>>>>>> parent of da8303b... done
				this.btnHit.Show();
				this.btnStay.Show();
				this.btnDoubleDown.Show();

				lblBalance.Text = String.Format("CA${0:0.00}", balance);
				Earnings = bet * 1 / 2;
				intEarnings = Convert.ToInt32(Earnings);
			}
<<<<<<< HEAD
<<<<<<< HEAD
			else if (nudBetAmount.Value > balance)
				// if the bet is over the balance display an error message.
=======
			else
>>>>>>> parent of da8303b... done
=======
			else
>>>>>>> parent of da8303b... done
				this.lblBetError.Text = "Your balance is too low";
			

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.btnHit.Hide();
			bet = bet * 0;
			this.btnStay.Hide();
			this.btnDoubleDown.Hide();
			this.lblCard1.Hide();
			this.lblCard2.Hide();
			this.lblCard3.Hide();
			this.lblDealerCard1.Hide();
			this.lblDealerCard2.Hide();
			this.lblDealerCard3.Hide();
			this.lblDealerCard4.Hide();
			this.lblDealerTotal.Hide();
			card1 = card1 * 0;
			card2 = card2 * 0;
			card3 = card3 * 0;
			dealerCard1 = dealerCard1 * 0;
			dealerCard2 = dealerCard2 * 0;
			dealerCard3 = dealerCard3 * 0;
			dealerCard4 = dealerCard4 * 0;
			lblBetError.Text = "--";
			playerCardTotal = playerCardTotal * 0;
			dealerCardTotal = dealerCardTotal * 0;




		}

		private void resetProgressToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bet = bet * 0;
			this.btnHit.Hide();
			this.btnStay.Hide();
			this.btnDoubleDown.Hide();
			this.lblCard1.Hide();
			this.lblCard2.Hide();
			this.lblCard3.Hide();
			this.lblDealerCard1.Hide();
			this.lblDealerCard2.Hide();
			this.lblDealerCard3.Hide();
			this.lblDealerCard4.Hide();
			this.lblDealerTotal.Hide();
			card1 = card1 * 0;
			card2 = card2 * 0;
			card3 = card3 * 0;
			dealerCard1 = dealerCard1 * 0;
			dealerCard2 = dealerCard2 * 0;
			dealerCard3 = dealerCard3 * 0;
			dealerCard4 = dealerCard4 * 0;
			playerCardTotal = playerCardTotal * 0;
			dealerCardTotal = dealerCardTotal * 0;
			lblBetError.Text = "--";
			balance = balance * 0 + 100;
            lblBalance.Text = String.Format("CA${0:0.00}", balance);

		}
	}
}
