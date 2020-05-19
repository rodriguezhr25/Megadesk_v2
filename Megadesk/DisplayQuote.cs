using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Megadesk
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote( string totalSize, string overage, string sizeCost, string drawerCost, string materialCost, string shippingCost, string total, string materialUsed, string shippingMethod, string customer, string strDateQuote)
                
        {
            InitializeComponent();

            txtTotalSize.Text = totalSize;
            txtSizeOverage.Text = overage;
            txtSizeCost.Text = sizeCost;
            txtDrawerCost.Text = drawerCost;
            txtMaterialCost.Text = materialCost;
            txtShipingCost.Text = shippingCost;
            txtTotal.Text = total;
            shipingMethod.Text = shippingMethod;
            txtMaterial.Text = materialUsed;
            txtCustomer.Text = customer;
            txtQuoteDate.Text = strDateQuote;



     


        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            //AddQuote addQuote = new AddQuote();
            //addQuote.Tag = this;
            //addQuote.Show(this);
            //Hide();
          
            //JObject quotesData = JObject.Parse(File.ReadAllText(path));
            //var list = JsonConvert.DeserializeObject<List<DeskQuote>>(quotesData);

            try
            {
                string path = Path.GetDirectoryName(Application.ExecutablePath) + "/data/quotes.json";
                JObject quotesData = JObject.Parse(File.ReadAllText(path));       
                var list = JsonConvert.DeserializeObject<List<Dictionary<String, String>>>(quotesData.ToString());
                //list.Add(new Dictionary<string, string>("Text", "Test"));
              
            }
            catch (Exception EX) { 


            }
        }

        private void txtCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
