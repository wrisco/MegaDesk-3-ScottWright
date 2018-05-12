namespace MegaDesk_3_ScottWright
{
	partial class SearchQuotes
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
			this.DisplayQuoteCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// DisplayQuoteCancel
			// 
			this.DisplayQuoteCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DisplayQuoteCancel.Location = new System.Drawing.Point(466, 391);
			this.DisplayQuoteCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DisplayQuoteCancel.Name = "DisplayQuoteCancel";
			this.DisplayQuoteCancel.Size = new System.Drawing.Size(112, 35);
			this.DisplayQuoteCancel.TabIndex = 0;
			this.DisplayQuoteCancel.Text = "&Cancel";
			this.DisplayQuoteCancel.UseVisualStyleBackColor = true;
			this.DisplayQuoteCancel.Click += new System.EventHandler(this.DisplayQuoteCancel_Click);
			// 
			// SearchQuotes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.DisplayQuoteCancel);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "SearchQuotes";
			this.Text = "Search Quotes";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchQuotes_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button DisplayQuoteCancel;
	}
}