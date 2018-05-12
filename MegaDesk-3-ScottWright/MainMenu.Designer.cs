namespace MegaDesk_3_ScottWright
{
	partial class MainMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
			this.AddNewQuote = new System.Windows.Forms.Button();
			this.ViewQuote = new System.Windows.Forms.Button();
			this.SearchQuote = new System.Windows.Forms.Button();
			this.Exit = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// AddNewQuote
			// 
			this.AddNewQuote.Location = new System.Drawing.Point(40, 39);
			this.AddNewQuote.Margin = new System.Windows.Forms.Padding(4);
			this.AddNewQuote.Name = "AddNewQuote";
			this.AddNewQuote.Size = new System.Drawing.Size(153, 43);
			this.AddNewQuote.TabIndex = 0;
			this.AddNewQuote.Text = "&Add New Quote";
			this.AddNewQuote.UseVisualStyleBackColor = true;
			this.AddNewQuote.Click += new System.EventHandler(this.AddNewQuote_Click);
			// 
			// ViewQuote
			// 
			this.ViewQuote.Location = new System.Drawing.Point(40, 106);
			this.ViewQuote.Margin = new System.Windows.Forms.Padding(4);
			this.ViewQuote.Name = "ViewQuote";
			this.ViewQuote.Size = new System.Drawing.Size(153, 43);
			this.ViewQuote.TabIndex = 1;
			this.ViewQuote.Text = "&View Quotes";
			this.ViewQuote.UseVisualStyleBackColor = true;
			this.ViewQuote.Click += new System.EventHandler(this.ViewQuote_Click);
			// 
			// SearchQuote
			// 
			this.SearchQuote.Location = new System.Drawing.Point(40, 180);
			this.SearchQuote.Margin = new System.Windows.Forms.Padding(4);
			this.SearchQuote.Name = "SearchQuote";
			this.SearchQuote.Size = new System.Drawing.Size(153, 43);
			this.SearchQuote.TabIndex = 2;
			this.SearchQuote.Text = "&Search Quotes";
			this.SearchQuote.UseVisualStyleBackColor = true;
			this.SearchQuote.Click += new System.EventHandler(this.SearchQuote_Click);
			// 
			// Exit
			// 
			this.Exit.Location = new System.Drawing.Point(40, 247);
			this.Exit.Margin = new System.Windows.Forms.Padding(4);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(153, 43);
			this.Exit.TabIndex = 3;
			this.Exit.Text = "E&xit";
			this.Exit.UseVisualStyleBackColor = true;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(276, 39);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(258, 261);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(605, 397);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.SearchQuote);
			this.Controls.Add(this.ViewQuote);
			this.Controls.Add(this.AddNewQuote);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainMenu";
			this.Text = "Mega Desk";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button AddNewQuote;
		private System.Windows.Forms.Button ViewQuote;
		private System.Windows.Forms.Button SearchQuote;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

