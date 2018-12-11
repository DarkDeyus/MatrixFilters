using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge;
using AForge.Imaging;

namespace MatrixFilters
{
    class Histogram
    {
        public int[] redValues;
        public int[] greenValues;
        public int[] blueValues;

        public Histogram(Bitmap b) => Calculate(b);

        public void Calculate(Bitmap b)
        {
            ImageStatistics rgbStatistics = new ImageStatistics(b);
            
            redValues = rgbStatistics.Red.Values;
            greenValues = rgbStatistics.Green.Values;
            blueValues = rgbStatistics.Blue.Values;
        }
        public Bitmap getRedHistogram => getHistogram(redValues, Color.Red);
        public Bitmap getGreenHistogram => getHistogram(greenValues, Color.Green);
        public Bitmap getBlueHistogram => getHistogram(blueValues, Color.Blue);
        private int[] SmoothHistogram(int[] originalValues)
        {
            int[] smoothedValues = new int[originalValues.Length];

            double[] mask = new double[] { 0.25, 0.5, 0.25 };

            for (int bin = 1; bin < originalValues.Length - 1; bin++)
            {
                double smoothedValue = 0;
                for (int i = 0; i < mask.Length; i++)
                {
                    smoothedValue += originalValues[bin - 1 + i] * mask[i];
                }
                smoothedValues[bin] = (int)smoothedValue;
            }

            return smoothedValues;
        }
        private Bitmap getHistogram(int[] histogram, Color color)
        {
            //int[] smoothHistogram = histogram;
            int[] smoothHistogram = SmoothHistogram(histogram);
            int max = smoothHistogram.Max();
            int height = 128;

            //Creates a histogram with a 5 units border around it
            Bitmap img = new Bitmap(256 + 10, height + 10);
            Pen pen = new Pen(color);
            using (Graphics g = Graphics.FromImage(img))
            {
                for (int i = 5; i < smoothHistogram.Length + 5; i++)
                {
                    // What percentage of the max is this value?
                    float percentage = (float)smoothHistogram[i - 5] / max;   
                    int a = img.Height;
                    g.DrawLine(pen, new System.Drawing.Point(i, img.Height - 5), new System.Drawing.Point(i, img.Height - 5 - (int)(percentage * (height))));
                }
            }
            return img;

        }
    }
}
