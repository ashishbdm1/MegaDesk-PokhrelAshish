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
    public partial class AddQuotes : Form
    {
        private Form _mainMenu;

        public AddQuotes(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;

        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void AddQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
