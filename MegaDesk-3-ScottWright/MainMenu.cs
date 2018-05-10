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
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		private void AddNewQuote_Click(object sender, EventArgs e)
		{
			AddQuote addNewQuoteForm = new AddQuote();
			addNewQuoteForm.Tag = this;
			addNewQuoteForm.Show(this);
			Hide();
		}
				
		private void ViewQuote_Click(object sender, EventArgs e)
		{
			ViewAllQuotes ViewAllQuotesForm = new ViewAllQuotes();
			ViewAllQuotesForm.Tag = this;
			ViewAllQuotesForm.Show(this);
			Hide();
		}

		private void SearchQuote_Click(object sender, EventArgs e)
		{
			SearchQuotes SearchQuoteForm = new SearchQuotes();
			SearchQuoteForm.Tag = this;
			SearchQuoteForm.Show(this);
			Hide();
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
