﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_ScottWright
{
	public partial class SearchQuotes : Form
	{
		public SearchQuotes()
		{
			InitializeComponent();
		}

		private void DisplayQuoteCancel_Click(object sender, EventArgs e)
		{
			var mainMenu = (MainMenu)Tag;
			mainMenu.Show();
			Close();
		}
	}
}
