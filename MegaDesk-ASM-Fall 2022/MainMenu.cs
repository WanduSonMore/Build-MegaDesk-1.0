using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_ASM_Fall_2022
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            // create and show Add Quote form
            var addQuote = new AddQuote(this);
            //addQuote.Tag = this;
            addQuote.Show();

            // hide Main Menu
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // this closes Main Menu
            Application.Exit();
        }

        //private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    Application.Exit();
        //}
    }
}
