using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PixelMapSharp;

namespace MatrixFilters
{
    
    static class Filter
    {
        internal static class ConstantFilters
        {
            internal static readonly int[,] IdentityMatrix =
            {
                {0, 0, 0 },
                {0, 1, 0 },
                {0, 0, 0 }
            };

            //SHARPEN
            internal static readonly int[,] SharpenMatrix =
            {
                { 0, -1,  0 },
                {-1,  5, -1 },
                { 0, -1,  0 }
            };

            internal static readonly int[,] MeanRemovalMatrix =
            {
                {-1, -1, -1 },
                {-1,  9, -1 },
                {-1, -1, -1 }
            };

            //EMBOSS

            internal readonly static int[,] EmbossEastMatrix =
            {
                { -1, 0, 1 },
                { -1, 1, 1 },
                { -1, 0, 1 }
            };

            internal readonly static int[,] EmbossSouthEastMatrix =
            {
                { -1, -1, 0 },
                { -1,  1, 1 },
                {  0,  1, 1 }
            };

            //BLUR

            internal static readonly int[,] BlurBox3Matrix =
            {
                { 1, 1, 1},
                { 1, 1, 1},
                { 1, 1, 1}
            };

            internal static readonly int[,] BlurGaussMatrix3 =
            {
                { 0, 1, 0 },
                { 1, 4, 1 },
                { 0, 1, 0 }
            };

            //EDGE DETECTION:

            internal static readonly int[,] EdgesVerticalMatrix =
            {
                {0, -1, 0 },
                {0,  1, 0 },
                {0,  0, 0 }
            };

            internal static readonly int[,] EdgesHorizontalMatrix =
            {
                { 0, 0, 0 },
                {-1, 1, 0 },
                { 0, 0, 0 }
            };

            internal static readonly int[,] EdgesDiagonalMatrix =
            {
                {-1, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 0 }
            };

            internal static readonly int[,] EdgesLaplaceMatrix =
            {
                {-1, -1, -1 },
                {-1,  8, -1 },
                {-1, -1, -1 }
            };

            
        }
        static public Bitmap UseFilter(Bitmap bitmap, int[,] filter, double divisor, int displacement, IBrush brush)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            PixelMap copy = new PixelMap(bitmap);
            PixelMap map = new PixelMap(width, height);

            for (int i = 0; i < width; i++)
            {
                map[i, 0] = copy[i, 0];
                map[i, height - 1] = copy[i, height - 1];
            }
                
            for(int j = 0; j < height; j++)
            {
                map[0, j] = copy[0, j];
                map[width - 1, j] = copy[width - 1, j];
            }


            for(int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    //use filter
                    if(brush.PointInBrush(x,y))
                    {
                        int R = 0;
                        int G = 0;
                        int B = 0;

                        for(int i = -1; i<= 1; i++)
                            for(int j= -1; j<= 1; j++ )
                            {
                                R += copy[x + i, y + j].R * filter[i + 1, j + 1];
                                G += copy[x + i, y + j].G * filter[i + 1, j + 1];
                                B += copy[x + i, y + j].B * filter[i + 1, j + 1];
                            }
                        R = (int)Math.Round(R / divisor) + displacement;
                        G = (int)Math.Round(G / divisor) + displacement;
                        B = (int)Math.Round(B / divisor) + displacement;
                        R = Math.Max(Math.Min(255, R), 0);
                        G = Math.Max(Math.Min(255, G), 0);
                        B = Math.Max(Math.Min(255, B), 0);
                        map[x, y] = new Pixel(R, G, B);
                    }
                    else
                    {
                        map[x, y] = copy[x, y]; 
                    }

                }
            }

            return map.GetBitmap();
        }
        public static Bitmap UseIdentityFilter(Bitmap bitmap, double divisor, int displacement, IBrush brush) => UseFilter(bitmap, ConstantFilters.IdentityMatrix, divisor, displacement, brush);
        public static Bitmap UseSharpenFilter(Bitmap bitmap, double divisor, int displacement, IBrush brush) => UseFilter(bitmap, ConstantFilters.SharpenMatrix, divisor, displacement, brush);
        public static Bitmap UseMeanRemovalFilter(Bitmap bitmap, double divisor, int displacement, IBrush brush) => UseFilter(bitmap, ConstantFilters.MeanRemovalMatrix, divisor, displacement, brush);
        public static Bitmap UseEmbossEastFilter(Bitmap bitmap, double divisor, int displacement, IBrush brush) => UseFilter(bitmap, ConstantFilters.EmbossEastMatrix, divisor, displacement, brush);
        public static Bitmap UseEmbossSouthEastFilter(Bitmap bitmap, double divisor, int displacement, IBrush brush) => UseFilter(bitmap, ConstantFilters.EmbossSouthEastMatrix, divisor, displacement, brush);
        public static Bitmap UseBlurBox3Filter(Bitmap bitmap, double divisor, int displacement, IBrush brush) => UseFilter(bitmap, ConstantFilters.BlurBox3Matrix, divisor, displacement, brush);
        public static Bitmap UseBlurGaussFilter(Bitmap bitmap, double divisor, int displacement, IBrush brush) => UseFilter(bitmap, ConstantFilters.BlurGaussMatrix3, divisor, displacement, brush);
        public static Bitmap UseEdgesVerticalFilter(Bitmap bitmap, double divisor, int displacement, IBrush brush) => UseFilter(bitmap, ConstantFilters.EdgesVerticalMatrix, divisor, displacement, brush);         
        public static Bitmap UseEdgesHorizontalFilter(Bitmap bitmap, double divisor, int displacement, IBrush brush) => UseFilter(bitmap, ConstantFilters.EdgesHorizontalMatrix, divisor, displacement, brush);
        public static Bitmap UseEdgesDiagonalFilter(Bitmap bitmap, double divisor, int displacement, IBrush brush) => UseFilter(bitmap, ConstantFilters.EdgesDiagonalMatrix, divisor, displacement, brush);
        public static Bitmap UseEdgesLaplaceFilter(Bitmap bitmap, double divisor, int displacement, IBrush brush) => UseFilter(bitmap, ConstantFilters.EdgesLaplaceMatrix, divisor, displacement, brush);

    }
}
