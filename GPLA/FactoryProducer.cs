using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLA
{
    class FactoryProducer
    {        
        /// Factory Creation                
        public static AbstractFactory getFactory(String choice)
        {
            //if condition to check if choice is shape or color
            if (choice.Equals("Shape"))
            {
                return new ShapeFactory();
            }

            return null;
        }

    }
}
