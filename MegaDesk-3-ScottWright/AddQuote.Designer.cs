namespace MegaDesk_3_ScottWright
{
	partial class AddQuote
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.CustomerName = new System.Windows.Forms.TextBox();
			this.DeskWidth = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.DeskDepth = new System.Windows.Forms.NumericUpDown();
			this.NumberOfDrawers = new System.Windows.Forms.ComboBox();
			this.AddQuoteSave = new System.Windows.Forms.Button();
			this.AddQuoteCancel = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.SurfaceMaterial = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.RushOrder = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.labelDate = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DeskWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DeskDepth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(39, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter Customer Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(92, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(158, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter Desk Size:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(72, 195);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(178, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Enter # of Drawers:";
			// 
			// CustomerName
			// 
			this.CustomerName.Location = new System.Drawing.Point(261, 70);
			this.CustomerName.Name = "CustomerName";
			this.CustomerName.Size = new System.Drawing.Size(176, 26);
			this.CustomerName.TabIndex = 1;
			// 
			// DeskWidth
			// 
			this.DeskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeskWidth.Location = new System.Drawing.Point(261, 147);
			this.DeskWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
			this.DeskWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.DeskWidth.Name = "DeskWidth";
			this.DeskWidth.Size = new System.Drawing.Size(73, 30);
			this.DeskWidth.TabIndex = 2;
			this.DeskWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(256, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(147, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Width (24\"-96\")";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(408, 119);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(148, 25);
			this.label5.TabIndex = 6;
			this.label5.Text = "Depth (12\"-48\")";
			// 
			// DeskDepth
			// 
			this.DeskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeskDepth.Location = new System.Drawing.Point(413, 147);
			this.DeskDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
			this.DeskDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.DeskDepth.Name = "DeskDepth";
			this.DeskDepth.Size = new System.Drawing.Size(70, 30);
			this.DeskDepth.TabIndex = 3;
			this.DeskDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			// 
			// NumberOfDrawers
			// 
			this.NumberOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberOfDrawers.FormattingEnabled = true;
			this.NumberOfDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
			this.NumberOfDrawers.Location = new System.Drawing.Point(261, 192);
			this.NumberOfDrawers.MaxDropDownItems = 7;
			this.NumberOfDrawers.Name = "NumberOfDrawers";
			this.NumberOfDrawers.Size = new System.Drawing.Size(121, 33);
			this.NumberOfDrawers.TabIndex = 4;
			// 
			// AddQuoteSave
			// 
			this.AddQuoteSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddQuoteSave.Location = new System.Drawing.Point(221, 394);
			this.AddQuoteSave.Name = "AddQuoteSave";
			this.AddQuoteSave.Size = new System.Drawing.Size(152, 34);
			this.AddQuoteSave.TabIndex = 7;
			this.AddQuoteSave.Text = "&Save Quote";
			this.AddQuoteSave.UseVisualStyleBackColor = true;
			// 
			// AddQuoteCancel
			// 
			this.AddQuoteCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddQuoteCancel.Location = new System.Drawing.Point(470, 394);
			this.AddQuoteCancel.Name = "AddQuoteCancel";
			this.AddQuoteCancel.Size = new System.Drawing.Size(152, 34);
			this.AddQuoteCancel.TabIndex = 8;
			this.AddQuoteCancel.Text = "&Cancel";
			this.AddQuoteCancel.UseVisualStyleBackColor = true;
			this.AddQuoteCancel.Click += new System.EventHandler(this.AddQuoteCancel_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(16, 248);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(234, 25);
			this.label6.TabIndex = 9;
			this.label6.Text = "Choose Surface Material:";
			// 
			// SurfaceMaterial
			// 
			this.SurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SurfaceMaterial.FormattingEnabled = true;
			this.SurfaceMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
			this.SurfaceMaterial.Location = new System.Drawing.Point(261, 245);
			this.SurfaceMaterial.Name = "SurfaceMaterial";
			this.SurfaceMaterial.Size = new System.Drawing.Size(121, 33);
			this.SurfaceMaterial.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(59, 306);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(191, 25);
			this.label7.TabIndex = 11;
			this.label7.Text = "Rush Order Options:";
			// 
			// RushOrder
			// 
			this.RushOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RushOrder.FormattingEnabled = true;
			this.RushOrder.Items.AddRange(new object[] {
            "None",
            "3 days",
            "5 days",
            "7 days"});
			this.RushOrder.Location = new System.Drawing.Point(261, 306);
			this.RushOrder.Name = "RushOrder";
			this.RushOrder.Size = new System.Drawing.Size(121, 33);
			this.RushOrder.TabIndex = 12;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(589, 124);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(189, 240);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(135, 33);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(114, 25);
			this.label8.TabIndex = 14;
			this.label8.Text = "Order Date:";
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDate.Location = new System.Drawing.Point(256, 33);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(94, 25);
			this.labelDate.TabIndex = 15;
			this.labelDate.Text = "labelDate";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(37, 71);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(211, 25);
			this.label9.TabIndex = 0;
			this.label9.Text = "Enter Customer Name:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(90, 147);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(158, 25);
			this.label10.TabIndex = 1;
			this.label10.Text = "Enter Desk Size:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(70, 195);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(178, 25);
			this.label11.TabIndex = 2;
			this.label11.Text = "Enter # of Drawers:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(14, 248);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(234, 25);
			this.label12.TabIndex = 9;
			this.label12.Text = "Choose Surface Material:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(57, 306);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(191, 25);
			this.label13.TabIndex = 11;
			this.label13.Text = "Rush Order Options:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(134, 33);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(114, 25);
			this.label14.TabIndex = 14;
			this.label14.Text = "Order Date:";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// AddQuote
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(843, 497);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.RushOrder);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.SurfaceMaterial);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.AddQuoteCancel);
			this.Controls.Add(this.AddQuoteSave);
			this.Controls.Add(this.NumberOfDrawers);
			this.Controls.Add(this.DeskDepth);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.DeskWidth);
			this.Controls.Add(this.CustomerName);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "AddQuote";
			this.RightToLeftLayout = true;
			this.Text = "New Quote";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddQuote_FormClosing);
			this.Load += new System.EventHandler(this.AddQuote_Load);
			((System.ComponentModel.ISupportInitialize)(this.DeskWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DeskDepth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox CustomerName;
		private System.Windows.Forms.NumericUpDown DeskWidth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown DeskDepth;
		private System.Windows.Forms.ComboBox NumberOfDrawers;
		private System.Windows.Forms.Button AddQuoteSave;
		private System.Windows.Forms.Button AddQuoteCancel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox SurfaceMaterial;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox RushOrder;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
	}
}