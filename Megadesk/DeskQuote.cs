using System;
using System.IO;
using System.Windows.Forms;

namespace Megadesk
{
    
    class DeskQuote
    {
        private DateTime quoteDate;
        private const double BASE_PRICE = 200;
        private const double DRAWERS_PRICE = 50;
        private int rushDays;
        private string customerName;
        private Desk desktop;
        private double deskSize;
       
        public DeskQuote()
        {

        }
        /*Construct a DeskQuote object with the specified rushDays, customerName, quoteDate
         *
         */
        public DeskQuote(int rushDays, string customerName, DateTime quoteDate, Desk desktop)
        {
            this.rushDays = rushDays;
            this.customerName = customerName;
            this.quoteDate = quoteDate;
            this.desktop = desktop;
        }
        /*
         * Set a new rushDays value for a DeskQuote object
         */
        public void setRushDays(int rushDays)
        {
            this.rushDays = rushDays;
        }
        /*
        * the getRushDays method
        * Purpose: to get the value of DeskQuote rushDays        
        */
        public double getRushDays()
        {
            return this.rushDays;
        }
        /*
        * Set a new customerName value for a DeskQuote object
        */
        public void setCustomerName(string customerName)
        {
            this.customerName = customerName;
        }
        /*
       * the getCustomerName method
       * Purpose: to get the value of DeskQuote customerName        
       */
        public string getCustomerName()
        {
            return this.customerName;
        }
        /*
      * Set a new quoteDate value for a DeskQuote object
      */
        public void setQuoteDate(DateTime quoteDate)
        {
            this.quoteDate = quoteDate;
        }
        /*
       * the getQuoteDate method
       * Purpose: to get the value of DeskQuote quoteDate        
       */
        public DateTime getQuoteDate()
        {
            return this.quoteDate;
        }
        /*
        * the getDeskSize method
        * Purpose: to compute the size of the desk using with and depth      
         */
        public double getDeskSize()
        {
            return desktop.getWidth() * desktop.getDepth();
        }
        /*
        * the getDrawersPrice method
        * Purpose: to compute total cost of drawers   
        */
        public double getDrawersPrice()
        {
            return desktop.getDrawers() * DRAWERS_PRICE;
        }

        /*
      * the getDeskType method
      * Purpose: return the type of desk small, medium , large depending of size
      */
        public string getDeskType()
        {
            deskSize = getDeskSize();
            string type = "";
            if(deskSize < 1000)
            {
                type = "small";
            }
            else if(deskSize < 2001)
            {
                type = "medium";
            }
            else
            {
                type = "large";
            }
            return type;
        }
        /*
        * the getRushDaysPrice method
        * Purpose: to compute total cost for the shipping
        * author: Hector Rodriguez // Antonio Lefiñir
        * create date:  5 may 2020
        */
        public double getRushDaysPrice()
        {
            string deskType = getDeskType();
            double rushOrderCost = 0;

            //obtain the costs of the rush order from file
            int[,] arrayOrdersCosts = getRushOrder();

            //!!ATTENTION if an error has occurred the array returns null
            if (arrayOrdersCosts != null)
            {
                switch (this.rushDays)
                {
                    case 3:
                        if (deskType == "small")
                        {
                            rushOrderCost = arrayOrdersCosts[0, 0];
                        }
                        else if (deskType == "medium")
                        {
                            rushOrderCost = arrayOrdersCosts[0, 1];
                        }
                        else
                        {
                            rushOrderCost = arrayOrdersCosts[0, 2];

                        }
                        break;
                    case 5:
                        if (deskType == "small")
                        {
                            rushOrderCost = arrayOrdersCosts[1, 0];
                        }
                        else if (deskType == "medium")
                        {
                            rushOrderCost = arrayOrdersCosts[1, 1];
                        }
                        else
                        {
                            rushOrderCost = arrayOrdersCosts[1, 2];

                        }
                        break;
                    case 7:
                        if (deskType == "small")
                        {
                            rushOrderCost = arrayOrdersCosts[2, 0];
                        }
                        else if (deskType == "medium")
                        {
                            rushOrderCost = arrayOrdersCosts[2, 1];
                        }
                        else
                        {
                            rushOrderCost = arrayOrdersCosts[2, 2];

                        }
                        break;
                }

            }
            return rushOrderCost;
        }
            /*
       * the getMaterialPrice method
       * Purpose: to compute total cost for the material used
       */
            public double getMaterialPrice()
            {
            string deskMaterial = desktop.getMaterial();
                double materialCost = 0;
                switch (deskMaterial)
                {
                case "Oak":
                    materialCost = 200;
                    break;
                case "Laminate":
                    materialCost = 100;
                    break;
                case "Pine":
                    materialCost = 50;
                    break;
                case "Rosewood":
                    materialCost = 300;
                    break;
                case "Veneer":
                    materialCost = 125;
                    break;


            }
                return materialCost;
            
        }
        /*
          * the getTotalPrice method
          * Purpose: to compute total desk cost
          */
        public double getSizeCost()
        {
            deskSize = getDeskSize();
            double surfaceExtra = 0;

            double sizeCost;
           
            if (deskSize > 1000)
            {
                surfaceExtra = deskSize - 1000;
            }
            sizeCost = surfaceExtra + BASE_PRICE;
            return sizeCost;           

        }
        /*
          * the getTotalPrice method
          * Purpose: to compute total desk cost
          */
        public double getTotalPrice()
        {
            deskSize = getDeskSize();         
            double costDrawers = getDrawersPrice();
            double costMaterial = getMaterialPrice();
            double costRushOrder = getRushDaysPrice();
            double costSize = getSizeCost();
            double totalPrice;

            
            totalPrice = costSize + costDrawers + costMaterial + costRushOrder;
            return totalPrice;

        }
        /*
        * the getRushOrder method
        * Purpose: to obtain the prices from a file
        * author: Antonio Lefiñir
        * create date:  5 may 2020
        */
        public int[,] getRushOrder()
        {
            //declare array and index
            int[,] arrayRushOrders = new int[3, 3];
            int xIndex = 0;
            int yIndex = 0;
            //get costs values from file
            try
            {
                //create file link
                StreamReader fileRushOrders = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "rushOrderPrices.txt");
                while (fileRushOrders.EndOfStream == false)
                {
                    string aLine = fileRushOrders.ReadLine();
                    //save into matrix
                    //check a valid number with parse method
                    try
                    {
                        //fill matrix
                        arrayRushOrders[xIndex, yIndex] = int.Parse(aLine);
                        yIndex++;

                        if (yIndex > 2)
                        {
                            yIndex = 0;
                            xIndex++;
                        }
                        //fileRushOrders.Close();

                    }
                    catch (FormatException)
                    {
                        fileRushOrders.Close();
                        return null;
                    }
                    catch (Exception exception)
                    {
                        fileRushOrders.Close();
                        return null;
                    }


                }
                fileRushOrders.Close();
            }
            catch (Exception e)
            {
                return null;
                //throw new ApplicationException("The file cannot be opened", e);
                
            }

            //if an error has occurred the array returns null
            return arrayRushOrders;

        }


    }
}
