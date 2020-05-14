using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Megadesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void customerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Tag = this;
            mainMenu.Show(this);
            Hide();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                double width = double.Parse(txtWidth.Text);
                double depth = double.Parse(txtDepth.Text);
                int drawers = Convert.ToInt32(numDrawers.Value);
                string material = cboMaterial.Text;
                string customerName = txtCustomerName.Text;
                DateTime dateQuote = DateTime.Now;
                int rushDays = int.Parse(cboRushOption.Text.Split(' ')[1]);
                Desk desktop = new Desk(width, depth, drawers, material);
                DeskQuote quote = new DeskQuote(rushDays, customerName, dateQuote, desktop);

                // Results
                double deskSize = quote.getDeskSize();

                string totalSize  = quote.getDeskSize().ToString();
                string overage="";
                if (deskSize > 1000)
                {
                    overage = (deskSize - 1000).ToString();
                }
                string sizeCost = quote.getSizeCost().ToString();
                string drawerCost = quote.getDrawersPrice().ToString();
                string materialCost = quote.getMaterialPrice().ToString();
                string shippingCost = quote.getRushDaysPrice().ToString();
                string total = quote.getTotalPrice().ToString();
                string materialUsed = desktop.getMaterial();
                string shippingMethod = cboRushOption.Text;
                string customer = quote.getCustomerName();
                string strDateQuote = quote.getQuoteDate().ToString();

                DisplayQuote displayQuote = new DisplayQuote(totalSize, overage, sizeCost, drawerCost, materialCost, shippingCost, total, materialUsed, shippingMethod,customer,strDateQuote);
                

                displayQuote.Tag = quote;
  
                displayQuote.Show(this);
                Hide();
            }catch (Exception ex)
            {

            }
        }
        private void txtWidth_Validating(object sender, CancelEventArgs e)
        {
            int width;
            string errorMsg;
            try
            {
                width = int.Parse(txtWidth.Text);

                if(width < 24 || width > 96)
                {
                    //Cancel the event, select the text to be corrected and focus on control
                    txtWidth.SelectAll();
                    e.Cancel = true;
                    errorMsg = "Min val: 24 , Max Val: 96";
                    this.errorProvider.SetError(txtWidth, errorMsg);
                }
            }
            catch (FormatException ex)
            {
                //Cancel the event, select the text to be corrected and focus on control
                txtWidth.SelectAll();
                e.Cancel = true;
                errorMsg = "Invalid width, enter a integer number";
                this.errorProvider.SetError(txtWidth, errorMsg);
               
               
               
            }
        }
        private void txtWidth_Validated(object sender, System.EventArgs e)
        {
            errorProvider.SetError(txtWidth, "");
        }

        private void txtDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !(Char.IsControl(e.KeyChar))){
                 e.Handled = true;
            }
        }

        private void txtDepth_Validating(object sender, CancelEventArgs e)
        {
            int depth;
            string errorMsg;
            try
            {
                depth = int.Parse(txtDepth.Text);

                if (depth < 12 || depth > 48)
                {
                    //Cancel the event, select the text to be corrected and focus on control
                    txtDepth.SelectAll();
                    e.Cancel = true;
                    errorMsg = "Min val: 12 , Max Val: 48";
                    this.errorProvider.SetError(txtDepth, errorMsg);
                }
               
            }
            catch (FormatException ex)
            {
                 // If keyPress event is desactived is the only to get an error
                //Cancel the event, select the text to be corrected and focus on control
                txtWidth.SelectAll();
                e.Cancel = true;
                errorMsg = ex.Message;
                this.errorProvider.SetError(txtDepth, errorMsg);



            }
        }
        private void txtDepth_Validated(object sender, System.EventArgs e)
        {
           
            errorProvider.SetError(txtDepth, "");
        }

     
    }
}
