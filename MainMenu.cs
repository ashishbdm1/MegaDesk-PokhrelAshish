using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_PokhrelAshish
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void AddQuoteBtn_Click(object sender, EventArgs e)
        {
            // create and show ad quote form
            var addQuote = new AddQuotes(this);
            addQuote.Tag = this;
            addQuote.Show();


            // hide main menu
            this.Hide();
        }

        private void DisplayQuoteBtn_Click(object sender, EventArgs e)
        {

            // create and show ad quote form
            var displayQuote = new Display_Quotes(this);
            displayQuote.Show();


            // hide main menu
            this.Hide();
        }

        private void SearchQuoteBtn_Click(object sender, EventArgs e)
        {

            // create and show ad quote form
            var searchQuote = new Search_Quotes(this);
            searchQuote.Show();


            // hide main menu
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
