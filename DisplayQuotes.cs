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
    public partial class Display_Quotes : Form
    {
        private Form _mainMenu;

        public Display_Quotes(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;

        }

        private void Display_Quotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
