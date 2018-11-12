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
			this.lblError = new System.Windows.Forms.Label();
			this.lblWinner = new System.Windows.Forms.Label();
			this.btnDone = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnHit = new System.Windows.Forms.Button();
			this.btnDoubleDown = new System.Windows.Forms.Button();
			this.btnStay = new System.Windows.Forms.Button();
			this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.muteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
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
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Location = new System.Drawing.Point(217, 310);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(13, 13);
			this.lblError.TabIndex = 1;
			this.lblError.Text = "--";
			// 
			// lblWinner
			// 
			this.lblWinner.AutoSize = true;
			this.lblWinner.Location = new System.Drawing.Point(217, 333);
			this.lblWinner.Name = "lblWinner";
			this.lblWinner.Size = new System.Drawing.Size(13, 13);
			this.lblWinner.TabIndex = 2;
			this.lblWinner.Text = "--";
			// 
			// btnDone
			// 
			this.btnDone.Location = new System.Drawing.Point(220, 267);
			this.btnDone.Name = "btnDone";
			this.btnDone.Size = new System.Drawing.Size(75, 23);
			this.btnDone.TabIndex = 3;
			this.btnDone.Text = "Done";
			this.btnDone.UseVisualStyleBackColor = true;
			this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Dealer Total:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(444, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Player total:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(447, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Balance:";
			// 
			// btnHit
			// 
			this.btnHit.Location = new System.Drawing.Point(5, 118);
			this.btnHit.Name = "btnHit";
			this.btnHit.Size = new System.Drawing.Size(75, 23);
			this.btnHit.TabIndex = 7;
			this.btnHit.Text = "Hit";
			this.btnHit.UseVisualStyleBackColor = true;
			this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
			// 
			// btnDoubleDown
			// 
			this.btnDoubleDown.Location = new System.Drawing.Point(101, 118);
			this.btnDoubleDown.Name = "btnDoubleDown";
			this.btnDoubleDown.Size = new System.Drawing.Size(80, 23);
			this.btnDoubleDown.TabIndex = 8;
			this.btnDoubleDown.Text = "DoubleDown";
			this.btnDoubleDown.UseVisualStyleBackColor = true;
			this.btnDoubleDown.Click += new System.EventHandler(this.btnDoubleDown_Click);
			// 
			// btnStay
			// 
			this.btnStay.Location = new System.Drawing.Point(199, 118);
			this.btnStay.Name = "btnStay";
			this.btnStay.Size = new System.Drawing.Size(75, 23);
			this.btnStay.TabIndex = 9;
			this.btnStay.Text = "Stay";
			this.btnStay.UseVisualStyleBackColor = true;
			this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
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
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnStay);
			this.Controls.Add(this.btnDoubleDown);
			this.Controls.Add(this.btnHit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDone);
			this.Controls.Add(this.lblWinner);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form2";
			this.Text = "Form2";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnHit;
		private System.Windows.Forms.Button btnDoubleDown;
		private System.Windows.Forms.Button btnStay;
		private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem muteToolStripMenuItem;
	}
}