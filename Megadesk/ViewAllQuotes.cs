﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Megadesk
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes(DataTable table)
        {
            InitializeComponent();
            dataGridAllQuotes.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Tag = this;
            mainMenu.Show(this);
            Hide();
        }


        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mainMenuP = new MainMenu();
            //mainMenuP.Tag = this;
            mainMenuP.Show();
            Hide();
        }
        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
          

        }
    }
}
