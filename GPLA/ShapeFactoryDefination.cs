using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLA
{    
    /// simple shape factory definition class
    public class ShapeFactoryDefination
    {        
        /// method to check if shape is circle        
        public bool isCircle(string shape)
        {
            if (shape == "circle")
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// method to check if shape is rectangle
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        public bool isRectangle(string shape)
        {
            if (shape == "rectangle")
            {
                return true;
            }
            return false;
        }

        public bool isTriangle(string shape)
        {
            if (shape == "triangle")
            {
                return true;
            }
            return false;
        }
    }
}
