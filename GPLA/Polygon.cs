using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLA
{
    class Polygon : Shape
    {

        public Polygon()
        {

        }
        public PointF[] polygon_vertices { get; set; }

        public override void draw(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(c, thickness);
            g.DrawPolygon(p, polygon_vertices);
        }
    }
}
