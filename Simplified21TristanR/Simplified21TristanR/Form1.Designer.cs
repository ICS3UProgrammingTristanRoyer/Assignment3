namespace Simplified21TristanR
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblUnderage = new System.Windows.Forms.Label();
			this.btnCheck = new System.Windows.Forms.Button();
			this.nudAge = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(312, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "How old are you?:";
			// 
			// lblUnderage
			// 
			this.lblUnderage.AutoSize = true;
			this.lblUnderage.Location = new System.Drawing.Point(339, 170);
			this.lblUnderage.Name = "lblUnderage";
			this.lblUnderage.Size = new System.Drawing.Size(13, 13);
			this.lblUnderage.TabIndex = 2;
			this.lblUnderage.Text = "--";
			this.lblUnderage.Click += new System.EventHandler(this.lblUnderage_Click);
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(330, 138);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(75, 23);
			this.btnCheck.TabIndex = 3;
			this.btnCheck.Text = "Check";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// nudAge
			// 
			this.nudAge.Location = new System.Drawing.Point(315, 112);
			this.nudAge.Name = "nudAge";
			this.nudAge.Size = new System.Drawing.Size(120, 20);
			this.nudAge.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.nudAge);
			this.Controls.Add(this.btnCheck);
			this.Controls.Add(this.lblUnderage);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblUnderage;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.NumericUpDown nudAge;
	}
}

