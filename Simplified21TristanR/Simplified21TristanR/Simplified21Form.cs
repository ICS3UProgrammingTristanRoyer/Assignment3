using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplified21TristanR
{
	public partial class Simplified21Form : Form
	{
		public Simplified21Form()
		{
			InitializeComponent();
		}

		private void lblUnderage_Click(object sender, EventArgs e)
		{

		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			// declare local variable
			int age;
			
			// assign the value entered by the user to the age variable
			age = (int)(nudAge.Value);

			// if age is over or equal to 21 call a new form to allow the user to play the game.Source:(https://stackoverflow.com/questions/3965043/how-to-open-a-new-form-from-another-form)
			if (age >= 21)
			{
				this.Hide();
				BlackJack Form2 = new BlackJack();
				Form2.ShowDialog();
			}
			// otherwise display an error message
			else if (age < 21)
			{ lblUnderage.Text = "you need to be 21 years of age to gamble"; }

		}
	}
}
