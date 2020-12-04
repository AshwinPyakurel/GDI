using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLA
{
    public abstract class Shape
    {
        //variable declared and initialized
        protected int x = 0, y = 0, z = 0;

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Shape(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        /// default constructor        
        public Shape()
        {
        }
        //start of getter setter
        public void setX(int x)
        {
            this.x = x;
        }
        public int getX()
        {
            return x;
        }

        public void setY(int y)
        {
            this.y = y;
        }
        public int getY()
        {
            return y;
        }
        ///end of getter setter
        /// draw method

        public abstract void draw(Graphics g, Color c, int thickness);
    }
}
