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


        /// <summary>
        /// draw method
        /// </summary>
        /// <param name="g"></param>
        public override void draw(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(c, thickness);
            g.DrawRectangle(p, x, y, height, width);
        }


        /// <summary>
        /// height setter
        /// </summary>
        /// <param name="height"></param>
        public void setHeight(int height)
        {
            this.height = height;
        }


        /// <summary>
        /// height getter
        /// </summary>
        /// <returns></returns>
        public int getHeight()
        {
            return this.height;
        }

        /// <summary>
        /// width setter
        /// </summary>
        /// <param name="width"></param>
        public void setWidth(int width)
        {
            this.width = width;
        }


        /// <summary>
        /// width getter
        /// </summary>
        /// <returns></returns>
        public int getWidth()
        {
            return this.width;
        }

    }
}
