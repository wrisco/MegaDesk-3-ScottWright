using System;
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
	public partial class AddQuote : Form
	{
		public AddQuote()
		{
			InitializeComponent();
		}

		private void AddQuoteCancel_Click(object sender, EventArgs e)
		{
			var mainMenu = (MainMenu)Tag;
			mainMenu.Show();
			Close();
		}

		private void AddQuote_Load(object sender, EventArgs e)
		{
			labelDate.Text = DateTime.Now.ToShortDateString();
		}

		private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
		{
			var mainMenu = (MainMenu)Tag;
			mainMenu.Show();
		}
	}
}
