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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void lblUnderage_Click(object sender, EventArgs e)
		{

		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			int age;

			age = (int)(nudAge.Value);

			if (age >= 21)
			{
				this.Hide();
				Form2 Form2 = new Form2();
				Form2.ShowDialog();
			}
			else if (age < 21)
			{ lblUnderage.Text = "you need to be 21 years of age to gamble"; }

		}
	}
}
