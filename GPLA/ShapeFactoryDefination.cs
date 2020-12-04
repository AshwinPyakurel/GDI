using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLA
{    
    /// ShapeFactoryDefination class created
    public class ShapeFactoryDefination
    {        
        /// Check if desired shape is circle or not
        public bool isCircle(string shape)
        {
            if (shape == "circle")
            {
                return true;
            }
            return false;
        }



        /// Check if desired shape is rectangle or not
        public bool isRectangle(string shape)
        {
            if (shape == "rectangle")
            {
                return true;
            }
            return false;
        }
      
    }
}
