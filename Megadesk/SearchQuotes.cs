using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Megadesk
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        List<DesktopMaterial> materials = new List<DesktopMaterial>();

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

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            foreach (DesktopMaterial item in Enum.GetValues(typeof(DesktopMaterial)))
            {
                materials.Add(item);
            }
            desktopMaterialComboBox.DataSource = materials;
            desktopMaterialComboBox.Text = "Select";

           
        }

        private void save_Click(object sender, EventArgs e)
        {
            //bind datagrid with datatable
            dataGridSearchQuotes.DataSource = DeskQuote.getAllQuotes();
        }
    }
        
}
