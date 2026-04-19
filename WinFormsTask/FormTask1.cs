using LibraryTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsTask
{
    public partial class FormTask1 : Form
    {
        public FormTask1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            double square = double.Parse(txtSquare.Text);
            //Одразу конвертуємо рядок в масив даблів
            double[] Rectangle = Array.ConvertAll(txtRectangle.Text.Split(','), double.Parse);
            double[] Triangle = Array.ConvertAll(txtTriangle.Text.Split(','), double.Parse);

            double s1 = Geometry.SquareArea(square);
            double s2 = Geometry.RectangleArea(Rectangle[0], Rectangle[1]);
            double s3 = Geometry.TriangleArea(Triangle[0], Triangle[1]);

            txtResult.Text =
                "Square: " + s1 + Environment.NewLine +
                "Rectangle: " + s2 + Environment.NewLine +
                "Triangle: " + s3;
        }
    }
}
