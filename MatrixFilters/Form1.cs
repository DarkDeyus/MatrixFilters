﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using System.Resources;

namespace MatrixFilters
{
    public partial class Form1 : Form
    {
        Bitmap picture;
        Bitmap currentPicture;
        IBrush brush = new WholeWindowBrush();
        bool draw = false;
        public Form1()
        {
            InitializeComponent();           
            picture = new Bitmap(Properties.Resources.tree);
            currentPicture = new Bitmap(picture);
            UpdateHistograms();
        }

        private void buttonNewPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "Image files (*.jpg, *.jpeg, *.png)| *.jpg; *.jpeg; *.png";
            openImage.Title = "Please select an image file";

            if (openImage.ShowDialog() == DialogResult.OK)
            {
                picture = new Bitmap(openImage.FileName);
                currentPicture = new Bitmap(picture);
                UpdateHistograms();
            }
            
        }

        void UpdateHistograms()
        {
            pictureBoxPicture.Image = currentPicture;
            Histogram histogram = new Histogram(currentPicture);
            pictureBoxRedHistogram.Image = histogram.getRedHistogram;
            pictureBoxGreenHistogram.Image = histogram.getGreenHistogram;
            pictureBoxBlueHistogram.Image = histogram.getBlueHistogram;
        }
        private void buttonRecalculate_Click(object sender, EventArgs e)
        {
            decimal divisor = checkBoxAutomaticDividers.Checked ? 1 : numericUpDownDivider.Value;
            if (divisor == 0)
            {
                MessageBox.Show("Nie można dzielić przez zero, zmień dzielnik na inny!");
                return;
            }

            int move = (int)numericUpDownMove.Value;

            if (radioButtonBlurBox3.Checked)
            {
                divisor = divisor == 1 ? 9 : divisor;
                currentPicture = Filter.UseBlurBox3Filter(picture, (double)divisor, move, brush);
            }

            else if (radioButtonBlurGauss.Checked)
            {
                divisor = divisor == 1 ? 8 : divisor;
                currentPicture = Filter.UseBlurGaussFilter(picture, (double)divisor, move, brush);
            }

            else if (radioButtonEdgesDiagonal.Checked)
                currentPicture = Filter.UseEdgesDiagonalFilter(picture, (double)divisor, move, brush);

            else if (radioButtonEdgesHorizontal.Checked)
                currentPicture = Filter.UseEdgesHorizontalFilter(picture, (double)divisor, move, brush);

            else if (radioButtonEdgesLaplace.Checked)
                currentPicture = Filter.UseEdgesLaplaceFilter(picture, (double)divisor, move, brush);

            else if (radioButtonEdgesVertical.Checked)
                currentPicture = Filter.UseEdgesVerticalFilter(picture, (double)divisor, move, brush);

            else if (radioButtonEmbossEast.Checked)
                currentPicture = Filter.UseEmbossEastFilter(picture, (double)divisor, move, brush);

            else if (radioButtonEmbossSouthEast.Checked)
                currentPicture = Filter.UseEmbossSouthEastFilter(picture, (double)divisor, move, brush);

            else if (radioButtonIdentity.Checked)
                currentPicture = Filter.UseIdentityFilter(picture, (double)divisor, move, brush);

            else if (radioButtonMeanRemoval.Checked)
                currentPicture = Filter.UseMeanRemovalFilter(picture, (double)divisor, move, brush);

            else if (radioButtonSharpen.Checked)
                currentPicture = Filter.UseSharpenFilter(picture, (double)divisor, move, brush);

            else if (radioButtonCustomFiltr.Checked)
            {

                int[,] matrix = new int[3, 3] { { (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value } ,
                                                { (int)numericUpDown4.Value, (int)numericUpDown5.Value, (int)numericUpDown6.Value } ,
                                                { (int)numericUpDown7.Value, (int)numericUpDown8.Value, (int)numericUpDown9.Value } };
              
                if (checkBoxAutomaticDividers.Checked)
                {
                    divisor = 0;
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            divisor += matrix[i, j];

                    if (divisor == 0)
                        divisor = 1;
                }               

                currentPicture = Filter.UseFilter(picture, matrix, (double)divisor, move, brush);
            }

            UpdateHistograms();
        }
        private void trackBarRadius_Scroll(object sender, EventArgs e)
        {
            labelScrollValue.Text = $"{trackBarRadius.Value}";
            if (radioButtonCircleBrush.Checked)
            {
                (brush as CircleBrush).R = trackBarRadius.Value;
                pictureBoxPicture.Refresh();
            }
        }

        private void buttonClearPolygonBrush_Click(object sender, EventArgs e)
        {
            if (radioButtonPolygonBrush.Checked)
            {
                draw = true;
                brush = new WholeWindowBrush();
                pictureBoxPicture.Refresh();
            }
        }
        private void radioButtonFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)(sender)).Checked)
                return;
            groupBoxCustomFilter.Enabled = false;

            if (radioButtonCustomFiltr.Checked)
                groupBoxCustomFilter.Enabled = true;

            return;
        }

        private void checkBoxAutomaticDividers_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutomaticDividers.Checked)
                numericUpDownDivider.Enabled = false;
            else
                numericUpDownDivider.Enabled = true;
        }
        private void radioButtonBrush_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonCircleBrush.Checked)
            {
                brush = new CircleBrush(pictureBoxPicture.Width / 2, pictureBoxPicture.Height / 2, trackBarRadius.Value);
            }
            else if(radioButtonPolygonBrush.Checked)
            {
                brush = new WholeWindowBrush();
                draw = true;
            }
            else if (radioButtonWholePicture.Checked)
            {
                brush = new WholeWindowBrush();
            }

            pictureBoxPicture.Refresh();
        }

        private void pictureBoxPicture_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen.Width = 5;
            if (radioButtonCircleBrush.Checked)
            {
                CircleBrush a = brush as CircleBrush;
                e.Graphics.DrawEllipse(pen, a.x - a.R / 2, a.y - a.R / 2, a.R, a.R);
            }
            else if (radioButtonPolygonBrush.Checked)
            {

            }
            
        }

        //TODO: BRUSHES
    }
}
