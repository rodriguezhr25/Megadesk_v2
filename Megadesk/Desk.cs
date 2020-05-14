using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megadesk
{

    enum DesktopMaterial
    {
        Laminate
        ,Oak
        ,Rosewood
        ,Veneer
        ,Pine
    };
   struct DeskProperties
    {
        public DesktopMaterial materials;
    }
    class Desk
    {
        private double width;
        private double depth;
        private int drawers;
        private string material;
        public const double MIN_WIDTH = 24;
        public const double MAX_WIDTH = 96;
        public const double MIN_DEPTH = 12;
        public const double MAX_DEPTH = 48;

        //default constructor of Desk object
        public Desk()
        {

        }
        /*Construct a Desk object with the specified width, depth, drawer
         * and material
         */
        public Desk(double width, double depth, int drawers, string material)
        {
            setWidth(width);
            setDepth(depth);
            setDrawers(drawers);
            setMaterial(material);
        }
        /*
         * Set a new width for a desk object
         */
        public void setWidth(double width)
        {
            this.width = width;
        }
        /*
        * the getWidth method
        * Purpose: to get the value of desk with        
        */
        public double getWidth()
        {
            return this.width;
        }
        /*
        * Set a new depth for a desk object
        */
        public void setDepth(double depth)
        {
            this.depth = depth;
        }
        /*
        * the getDepth method
        * Purpose: to get the value of desk with         
        */
        public double getDepth()
        {
            return this.depth;
        }
        /*
        * Set a new value for drawers of a desk object
        */
        public void setDrawers(int drawers)
        {
            this.drawers = drawers;
        }
        /*
        * the getDrawers method
        * Purpose: to get the value of desk drawers         
        */
        public double getDrawers()
        {
            return this.drawers;
        }

        /*
       * Set a new value for material of a desk object
       */
        public void setMaterial(string material)
        {
            this.material = material;
        }
        /*
        * the getMaterial method
        * Purpose: to get the value of desk material         
        */
        public string getMaterial()
        {
            return this.material;
        }
    }
}
