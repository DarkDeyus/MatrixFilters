using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixFilters
{
    interface IBrush
    {
        bool PointInBrush(int pointX, int pointY);
        void Move(int xDiff, int yDiff);
        void Draw(PaintEventArgs e, Pen pen);
    }


    class CircleBrush : IBrush
    {
        public int R;
        public int x;
        public int y;

        public CircleBrush(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            R = r;
        }

        public void Draw(PaintEventArgs e, Pen pen)
        {
            e.Graphics.DrawEllipse(pen, x - R, y - R, R * 2, R * 2);
        }

        public void Move(int xDiff, int yDiff)
        {
            x += xDiff;
            y += yDiff;
        }

        public bool PointInBrush(int pointX, int pointY)
        {
            return Math.Pow(x - pointX, 2) + Math.Pow(y - pointY, 2) <= (R * R);
        }


    }


    class PolygonBrush : IBrush
    {
        Polygon polygon;
        public PolygonBrush(Polygon poly) => polygon = poly;

        public void Draw(PaintEventArgs e, Pen pen)
        {
            polygon.Draw(e, pen);            
        }

        public List<Vertex> getVertices() => polygon.getPolygonVertices();
        public void Move(int xDiff, int yDiff)
        {
            polygon.movePolygon(xDiff, yDiff);
        }

        public bool PointInBrush(int x, int y)
        {
            return polygon.IsPointInPolygon(x, y);
        }
    }


    class WholeWindowBrush : IBrush
    {
        public void Draw(PaintEventArgs e, Pen pen) { }      

        public void Move(int xDiff, int yDiff) { }

        public bool PointInBrush(int x, int y) => true;
    }
}
