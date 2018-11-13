namespace Simplified21TristanR
{
	partial class Form2
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.muteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblError = new System.Windows.Forms.Label();
			this.lblWinner = new System.Windows.Forms.Label();
			this.btnDone = new System.Windows.Forms.Button();
			this.lblDealerTotal = new System.Windows.Forms.Label();
			this.lblPlayerTotal = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnHit = new System.Windows.Forms.Button();
			this.btnDoubleDown = new System.Windows.Forms.Button();
			this.btnStay = new System.Windows.Forms.Button();
			this.nudBetAmount = new System.Windows.Forms.NumericUpDown();
			this.lblBetAmount = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lblCard1 = new System.Windows.Forms.Label();
			this.lblCard2 = new System.Windows.Forms.Label();
			this.lblCard3 = new System.Windows.Forms.Label();
			this.lblPlayer = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblDealerCard1 = new System.Windows.Forms.Label();
			this.lblDealerCard2 = new System.Windows.Forms.Label();
			this.lblDealerCard3 = new System.Windows.Forms.Label();
			this.lblBalance = new System.Windows.Forms.Label();
			this.lblBetError = new System.Windows.Forms.Label();
			this.lblDealerCard4 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBetAmount)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.musicToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetProgressToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.newGameToolStripMenuItem.Text = "New Game";
			// 
			// resetProgressToolStripMenuItem
			// 
			this.resetProgressToolStripMenuItem.Name = "resetProgressToolStripMenuItem";
			this.resetProgressToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.resetProgressToolStripMenuItem.Text = "Reset Progress";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// musicToolStripMenuItem
			// 
			this.musicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resumeToolStripMenuItem,
            this.muteToolStripMenuItem});
			this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
			this.musicToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.musicToolStripMenuItem.Text = "Music";
			// 
			// resumeToolStripMenuItem
			// 
			this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
			this.resumeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.resumeToolStripMenuItem.Text = "Resume";
			this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
			// 
			// muteToolStripMenuItem
			// 
			this.muteToolStripMenuItem.Name = "muteToolStripMenuItem";
			this.muteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.muteToolStripMenuItem.Text = "Mute";
			this.muteToolStripMenuItem.Click += new System.EventHandler(this.muteToolStripMenuItem_Click);
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Location = new System.Drawing.Point(266, 374);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(13, 13);
			this.lblError.TabIndex = 1;
			this.lblError.Text = "--";
			// 
			// lblWinner
			// 
			this.lblWinner.AutoSize = true;
			this.lblWinner.Location = new System.Drawing.Point(266, 402);
			this.lblWinner.Name = "lblWinner";
			this.lblWinner.Size = new System.Drawing.Size(13, 13);
			this.lblWinner.TabIndex = 2;
			this.lblWinner.Text = "--";
			// 
			// btnDone
			// 
			this.btnDone.Location = new System.Drawing.Point(262, 336);
			this.btnDone.Name = "btnDone";
			this.btnDone.Size = new System.Drawing.Size(75, 23);
			this.btnDone.TabIndex = 3;
			this.btnDone.Text = "Done";
			this.btnDone.UseVisualStyleBackColor = true;
			this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
			// 
			// lblDealerTotal
			// 
			this.lblDealerTotal.AutoSize = true;
			this.lblDealerTotal.Location = new System.Drawing.Point(7, 235);
			this.lblDealerTotal.Name = "lblDealerTotal";
			this.lblDealerTotal.Size = new System.Drawing.Size(68, 13);
			this.lblDealerTotal.TabIndex = 4;
			this.lblDealerTotal.Text = "Dealer Total:";
			// 
			// lblPlayerTotal
			// 
			this.lblPlayerTotal.AutoSize = true;
			this.lblPlayerTotal.Location = new System.Drawing.Point(7, 120);
			this.lblPlayerTotal.Name = "lblPlayerTotal";
			this.lblPlayerTotal.Size = new System.Drawing.Size(62, 13);
			this.lblPlayerTotal.TabIndex = 5;
			this.lblPlayerTotal.Text = "Player total:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Red;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(595, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Balance:";
			// 
			// btnHit
			// 
			this.btnHit.BackColor = System.Drawing.Color.Lime;
			this.btnHit.Location = new System.Drawing.Point(5, 53);
			this.btnHit.Name = "btnHit";
			this.btnHit.Size = new System.Drawing.Size(75, 23);
			this.btnHit.TabIndex = 7;
			this.btnHit.Text = "Hit";
			this.btnHit.UseVisualStyleBackColor = false;
			this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
			// 
			// btnDoubleDown
			// 
			this.btnDoubleDown.BackColor = System.Drawing.Color.Green;
			this.btnDoubleDown.Location = new System.Drawing.Point(89, 53);
			this.btnDoubleDown.Name = "btnDoubleDown";
			this.btnDoubleDown.Size = new System.Drawing.Size(80, 23);
			this.btnDoubleDown.TabIndex = 8;
			this.btnDoubleDown.Text = "DoubleDown";
			this.btnDoubleDown.UseVisualStyleBackColor = false;
			this.btnDoubleDown.Click += new System.EventHandler(this.btnDoubleDown_Click);
			// 
			// btnStay
			// 
			this.btnStay.BackColor = System.Drawing.Color.Aqua;
			this.btnStay.Location = new System.Drawing.Point(175, 53);
			this.btnStay.Name = "btnStay";
			this.btnStay.Size = new System.Drawing.Size(75, 23);
			this.btnStay.TabIndex = 9;
			this.btnStay.Text = "Stay";
			this.btnStay.UseVisualStyleBackColor = false;
			this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
			// 
			// nudBetAmount
			// 
			this.nudBetAmount.Location = new System.Drawing.Point(680, 56);
			this.nudBetAmount.Name = "nudBetAmount";
			this.nudBetAmount.Size = new System.Drawing.Size(120, 20);
			this.nudBetAmount.TabIndex = 10;
			// 
			// lblBetAmount
			// 
			this.lblBetAmount.AutoSize = true;
			this.lblBetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBetAmount.Location = new System.Drawing.Point(554, 58);
			this.lblBetAmount.Name = "lblBetAmount";
			this.lblBetAmount.Size = new System.Drawing.Size(120, 18);
			this.lblBetAmount.TabIndex = 11;
			this.lblBetAmount.Text = "Make your bet:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(680, 80);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "Bet";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblCard1
			// 
			this.lblCard1.AutoSize = true;
			this.lblCard1.Location = new System.Drawing.Point(12, 148);
			this.lblCard1.Name = "lblCard1";
			this.lblCard1.Size = new System.Drawing.Size(43, 13);
			this.lblCard1.TabIndex = 13;
			this.lblCard1.Text = "CARD1";
			this.lblCard1.Click += new System.EventHandler(this.label4_Click);
			// 
			// lblCard2
			// 
			this.lblCard2.AutoSize = true;
			this.lblCard2.Location = new System.Drawing.Point(86, 148);
			this.lblCard2.Name = "lblCard2";
			this.lblCard2.Size = new System.Drawing.Size(43, 13);
			this.lblCard2.TabIndex = 14;
			this.lblCard2.Text = "CARD2";
			// 
			// lblCard3
			// 
			this.lblCard3.AutoSize = true;
			this.lblCard3.Location = new System.Drawing.Point(167, 148);
			this.lblCard3.Name = "lblCard3";
			this.lblCard3.Size = new System.Drawing.Size(43, 13);
			this.lblCard3.TabIndex = 15;
			this.lblCard3.Text = "CARD3";
			// 
			// lblPlayer
			// 
			this.lblPlayer.AutoSize = true;
			this.lblPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
			this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayer.Location = new System.Drawing.Point(11, 83);
			this.lblPlayer.Name = "lblPlayer";
			this.lblPlayer.Size = new System.Drawing.Size(58, 20);
			this.lblPlayer.TabIndex = 16;
			this.lblPlayer.Text = "Player";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Red;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 194);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 20);
			this.label5.TabIndex = 17;
			this.label5.Text = "Dealer";
			// 
			// lblDealerCard1
			// 
			this.lblDealerCard1.AutoSize = true;
			this.lblDealerCard1.Location = new System.Drawing.Point(12, 269);
			this.lblDealerCard1.Name = "lblDealerCard1";
			this.lblDealerCard1.Size = new System.Drawing.Size(86, 13);
			this.lblDealerCard1.TabIndex = 18;
			this.lblDealerCard1.Text = "DEALERCARD1";
			// 
			// lblDealerCard2
			// 
			this.lblDealerCard2.AutoSize = true;
			this.lblDealerCard2.Location = new System.Drawing.Point(105, 269);
			this.lblDealerCard2.Name = "lblDealerCard2";
			this.lblDealerCard2.Size = new System.Drawing.Size(86, 13);
			this.lblDealerCard2.TabIndex = 19;
			this.lblDealerCard2.Text = "DEALERCARD2";
			// 
			// lblDealerCard3
			// 
			this.lblDealerCard3.AutoSize = true;
			this.lblDealerCard3.Location = new System.Drawing.Point(201, 269);
			this.lblDealerCard3.Name = "lblDealerCard3";
			this.lblDealerCard3.Size = new System.Drawing.Size(86, 13);
			this.lblDealerCard3.TabIndex = 20;
			this.lblDealerCard3.Text = "DEALERCARD3";
			this.lblDealerCard3.Click += new System.EventHandler(this.label8_Click);
			// 
			// lblBalance
			// 
			this.lblBalance.AutoSize = true;
			this.lblBalance.BackColor = System.Drawing.Color.Green;
			this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBalance.Location = new System.Drawing.Point(711, 29);
			this.lblBalance.Name = "lblBalance";
			this.lblBalance.Size = new System.Drawing.Size(15, 16);
			this.lblBalance.TabIndex = 21;
			this.lblBalance.Text = "0";
			// 
			// lblBetError
			// 
			this.lblBetError.AutoSize = true;
			this.lblBetError.Location = new System.Drawing.Point(557, 119);
			this.lblBetError.Name = "lblBetError";
			this.lblBetError.Size = new System.Drawing.Size(13, 13);
			this.lblBetError.TabIndex = 22;
			this.lblBetError.Text = "--";
			// 
			// lblDealerCard4
			// 
			this.lblDealerCard4.AutoSize = true;
			this.lblDealerCard4.Location = new System.Drawing.Point(302, 269);
			this.lblDealerCard4.Name = "lblDealerCard4";
			this.lblDealerCard4.Size = new System.Drawing.Size(86, 13);
			this.lblDealerCard4.TabIndex = 23;
			this.lblDealerCard4.Text = "DEALERCARD4";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblDealerCard4);
			this.Controls.Add(this.lblBetError);
			this.Controls.Add(this.lblBalance);
			this.Controls.Add(this.lblDealerCard3);
			this.Controls.Add(this.lblDealerCard2);
			this.Controls.Add(this.lblDealerCard1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblPlayer);
			this.Controls.Add(this.lblCard3);
			this.Controls.Add(this.lblCard2);
			this.Controls.Add(this.lblCard1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblBetAmount);
			this.Controls.Add(this.nudBetAmount);
			this.Controls.Add(this.btnStay);
			this.Controls.Add(this.btnDoubleDown);
			this.Controls.Add(this.btnHit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblPlayerTotal);
			this.Controls.Add(this.lblDealerTotal);
			this.Controls.Add(this.btnDone);
			this.Controls.Add(this.lblWinner);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form2";
			this.Text = "Form2";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBetAmount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetProgressToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.Label lblWinner;
		private System.Windows.Forms.Button btnDone;
		private System.Windows.Forms.Label lblDealerTotal;
		private System.Windows.Forms.Label lblPlayerTotal;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnHit;
		private System.Windows.Forms.Button btnDoubleDown;
		private System.Windows.Forms.Button btnStay;
		private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem muteToolStripMenuItem;
		private System.Windows.Forms.NumericUpDown nudBetAmount;
		private System.Windows.Forms.Label lblBetAmount;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblCard1;
		private System.Windows.Forms.Label lblCard2;
		private System.Windows.Forms.Label lblCard3;
		private System.Windows.Forms.Label lblPlayer;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblDealerCard1;
		private System.Windows.Forms.Label lblDealerCard2;
		private System.Windows.Forms.Label lblDealerCard3;
		private System.Windows.Forms.Label lblBalance;
		private System.Windows.Forms.Label lblBetError;
		private System.Windows.Forms.Label lblDealerCard4;
	}
}