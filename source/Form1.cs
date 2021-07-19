using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace source
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Image image = new Bitmap("InputColour.bmp");
            ImageAttributes imageAttributes = new ImageAttributes();

            int width = image.Width;
            int height = image.Height;

            float[][] colorMatrixElements =
            {
                     new float[] {2,  0,  0,  0, 0},       
                     new float[] {0,  1,  0,  0, 0},        
                     new float[] {0,  0,  1,  0, 0},        
                     new float[] {0,  0,  0,  1, 0},       
                     new float[] {.2f, .2f, .2f, 0, 1}
        };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
        }
    }
}
