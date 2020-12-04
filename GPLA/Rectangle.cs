using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLA
{
    class Rectangle : Shape
    {
        //declaration of variables
        int height, width;

        
        /// Parameterized constructor        
        public Rectangle(int x, int y, int height, int width) : base(x, y)
        {
            this.height = height;
            this.width = width;
        }

        /// another parameterized constructor        
        public Rectangle(int x, int y) : base(x, y)
        {

        }

        /// default constructor       
        public Rectangle()
        {
        }


        /// draw method created
        public override void draw(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(c, thickness);
            g.DrawRectangle(p, x, y, height, width);
        }

        
        // Start or getter setter      
        public void setHeight(int height)
        {
            this.height = height;
        }

        
        public int getHeight()
        {
            return this.height;
        }
        public void setWidth(int width)
        {
            this.width = width;
        }
        public int getWidth()
        {
            return this.width;
        }
        //end of getter setter

    }
}
