using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLA
{
    public class Circle : Shape
    {


        int radius;//Radius declaration
        
        // parameterized constructor
        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;

        }

        
        /// default constructor
        
        public Circle()
        {

        }

        public Circle(int radius)
        {
            this.radius = radius;
        }
        
        ///parameterized constructor        

        public Circle(int x, int y) : base(x, y)
        {

        }
        
        /// draw method       
        public override void draw(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(c, thickness);
            g.DrawEllipse(p, x, y, radius, radius);
        }

        public void setRadius(int radius)
        {
            this.radius = radius;
        }
                
        public int getRadius()
        {
            return this.radius;
        }
    }
}
