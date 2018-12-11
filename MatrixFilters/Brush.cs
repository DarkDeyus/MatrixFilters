using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFilters
{
    interface IBrush
    {
        bool PointInBrush(int pointX, int pointY);
        void Move(int xDiff, int yDiff);
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

        public void Move(int xDiff, int yDiff)
        {
            x += xDiff;
            y += yDiff;
        }

        public bool PointInBrush(int pointX, int pointY)
        {
            double dist = Math.Pow(pointX - x, 2) + Math.Pow(pointY - y, 2);

            if (dist <= (R * R))
            {
                int b = 2;
                return true;
            }
                
            int a = 2;
            return false;
        }
    }

    class PolygonBrush : IBrush
    {
        Polygon polygon;
        public PolygonBrush(Polygon poly) => polygon = poly;

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
        public void Move(int xDiff, int yDiff) { }

        public bool PointInBrush(int x, int y) => true;
    }
}
