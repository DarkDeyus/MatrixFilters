using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Point ToPoint() => new Point(X, Y);

        static public int containsVertex(List<Vertex> vertices, double leeway, Vertex v)
        {
            for (int i = 0; i < vertices.Count; i++)
            {
                double a = vertices[i].X - v.X;
                double b = vertices[i].Y - v.Y;

                //Pythagoras theorem, faster to square than to take a square root 
                if (a * a + b * b < leeway * leeway)
                    return i;
            }
            return -1;
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
        public List<Vertex> getPolygonVertices() => vertices;
        public bool IsPointInPolygon(int x, int y)
        {
            bool result = false;
            int j = vertices.Count() - 1;
            for (int i = 0; i < vertices.Count(); i++)
            {
                if (vertices[i].Y < y && vertices[j].Y >= y || vertices[j].Y < y && vertices[i].Y >= y)
                {
                    if (vertices[i].X + (double)(y - vertices[i].Y) / (double)(vertices[j].Y - vertices[i].Y) * (double)(vertices[j].X - vertices[i].X) < x)
                    {
                        result = !result;
                    }
                }
                j = i;
            }
            return result;
        }

        public void Draw(PaintEventArgs e, Pen pen)
        {
            for (int i = 0; i < vertices.Count; i++)
            {
                e.Graphics.DrawLine(pen, vertices[i].ToPoint(), vertices[(i + 1) % vertices.Count].ToPoint());
                Rectangle rect = new Rectangle(vertices[i].X - 5, vertices[i].Y - 5, 10, 10);
                e.Graphics.DrawEllipse(pen, rect);
                e.Graphics.FillEllipse(Brushes.Black, rect);
            }
        }
        
    }


}
