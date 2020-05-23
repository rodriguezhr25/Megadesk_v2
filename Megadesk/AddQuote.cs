using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Megadesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        List<DesktopMaterial> materials = new List<DesktopMaterial>();
      

        private void AddQuote_Load(object sender, EventArgs e)
        {
            foreach (DesktopMaterial item in Enum.GetValues(typeof(DesktopMaterial)))
            {
                materials.Add(item);
            }
            cboMaterial.DataSource = materials;
     
                
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

                    string totalSize = quote.getDeskSize().ToString();
                    string overage = "";
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


                    string pathSave = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"data\quotes.json");
                    string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"data\quotes.json");
                    string json = File.ReadAllText(path);
                    var jsonObj = JObject.Parse(json);

                    //Count how many quotes are in the file and create Array with existing quotes
                    var quoteArray = jsonObj.GetValue("quotes") as JArray;
                    int count = quoteArray.Count;

                    //Add new quote to Dictionary
                    Dictionary<string, Object> quoteData = new Dictionary<string, Object>();
                    quoteData.Add("id", count + 1);
                    quoteData.Add("customer", customer);

                    string jsonIsoDate = JsonConvert.SerializeObject(quote.getQuoteDate());

                    quoteData.Add("dateQuote", jsonIsoDate);
                    quoteData.Add("costSize", sizeCost);
                    quoteData.Add("totalSize", totalSize);
                    quoteData.Add("sizeOverage", overage);
                    quoteData.Add("drawerCost", drawerCost);
                    quoteData.Add("material", materialUsed);
                    quoteData.Add("materialCost", materialCost);
                    quoteData.Add("shippingMethod", shippingMethod);
                    quoteData.Add("shippingCost", shippingCost);
                    quoteData.Add("total", total);
                    List<Dictionary<String, Object>> _data = new List<Dictionary<String, Object>>();
                    _data.Add(new Dictionary<String, Object>(quoteData));


                    //Convert Dictionary to JsonObject
                    var newJsonQuote = JsonConvert.SerializeObject(_data[0], Formatting.Indented);
                    var newQuote = JObject.Parse(newJsonQuote);
                    //Add new quote to array
                    quoteArray.Add(newQuote);
                    jsonObj["quotes"] = quoteArray;
                    //Saving file with new Json
                    string newJsonResult = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
                    File.WriteAllText(pathSave, newJsonResult);
                    //Display quote
                    DisplayQuote displayQuote = new DisplayQuote(totalSize, overage, sizeCost, drawerCost, materialCost, shippingCost, total, materialUsed, shippingMethod, customer, strDateQuote);
                    displayQuote.Tag = quote;
                    displayQuote.Show(this);
                    Hide();
            } catch (DirectoryNotFoundException)
            {                // Let the user know that the directory did not exist.     
                MessageBox.Show("Directory not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }catch (FormatException)
            {
                // Let the user know that the data is incorrect   
                MessageBox.Show("Format error, register all data correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException)
            {
                // Let the user know that the data is incorrect   
                MessageBox.Show("Select a valid option for shipping", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonReaderException)
            {
                // Let the user know that the json is corrupted   
                MessageBox.Show("The Json file is corrupted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtWidth_Validating(object sender, CancelEventArgs e)
        {
            Desk mydesk = new Desk();
            int width;
            string errorMsg;
            try
            {
                width = int.Parse(txtWidth.Text);

                if(width < Desk.MIN_WIDTH || width > Desk.MAX_WIDTH)
                {
                    //Cancel the event, select the text to be corrected and focus on control
                    txtWidth.SelectAll();
                    e.Cancel = true;
                    errorMsg = "Min val: " +  Desk.MIN_WIDTH   +  " Max Val: " + Desk.MAX_WIDTH;
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

                if (depth < Desk.MIN_DEPTH || depth > Desk.MAX_DEPTH)
                {
                    //Cancel the event, select the text to be corrected and focus on control
                    txtDepth.SelectAll();
                    e.Cancel = true;
                    errorMsg = "Min val: " + Desk.MIN_DEPTH + " Max Val: " + Desk.MAX_DEPTH;
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

        private void numDrawers_Enter(object sender, System.EventArgs e)
        {

            numDrawers.Select(0, numDrawers.Text.Length);
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mainMenuP = new MainMenu();
            //mainMenuP.Tag = this;
            mainMenuP.Show();
            Hide();
        }
    }   



}
