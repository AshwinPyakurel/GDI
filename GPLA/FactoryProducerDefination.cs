using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLA
{

   
    /// Factory definition class created
    public class FactoryProducerDefination
    {
        
        /// checks for shape or color to be made        
        public bool isShape(string type)
        {
            if (type == "shape")
            {
                return true;
            }
            return false;
        }
    }
}
