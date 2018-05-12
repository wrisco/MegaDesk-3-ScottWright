namespace MegaDesk_3_ScottWright
{
	partial class ViewAllQuotes
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
			this.ViewAllQuotesCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ViewAllQuotesCancel
			// 
			this.ViewAllQuotesCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ViewAllQuotesCancel.Location = new System.Drawing.Point(538, 363);
			this.ViewAllQuotesCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ViewAllQuotesCancel.Name = "ViewAllQuotesCancel";
			this.ViewAllQuotesCancel.Size = new System.Drawing.Size(112, 35);
			this.ViewAllQuotesCancel.TabIndex = 0;
			this.ViewAllQuotesCancel.Text = "&Cancel";
			this.ViewAllQuotesCancel.UseVisualStyleBackColor = true;
			this.ViewAllQuotesCancel.Click += new System.EventHandler(this.ViewAllQuotesCancel_Click);
			// 
			// ViewAllQuotes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.ViewAllQuotesCancel);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ViewAllQuotes";
			this.Text = "ViewAllQuotes";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAllQuotes_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ViewAllQuotesCancel;
	}
}