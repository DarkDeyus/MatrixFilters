using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFilters
{
    class Vertex
    {
        public int X;
        public int Y;

        public Vertex(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    class Polygon
    {
        List<Vertex> vertices;
        public Polygon(List<Vertex> list) => vertices = list;
        public void movePolygon(int X, int Y)
        {
            for (int i = 0; i < vertices.Count; i++)
            {
                vertices[i].X += X;
                vertices[i].Y += Y;
            }
        }
        public bool IsPointInPolygon(int x, int y)
        {
            bool result = false;
            int j = vertices.Count() - 1;
            for (int i = 0; i < vertices.Count(); i++)
            {
                if (vertices[i].Y < y && vertices[j].Y >= y || vertices[j].Y < y && vertices[i].Y >= y)
                {
                    if (vertices[i].X + (y - vertices[i].Y) / (vertices[j].Y - vertices[i].Y) * (vertices[j].X - vertices[i].X) < x)
                    {
                        result = !result;
                    }
                }
                j = i;
            }
            return result;
        }
    }


}
