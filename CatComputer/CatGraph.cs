using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatControls
{
    public partial class CatGraph : UserControl
    {
        public int[] data;
        public int[] data2;
        public string label;
        public int currentTime = 0;

        public CatGraph()
        {
            InitializeComponent();
        }

        public void ShowData(string l, int[] d, int[] d2 = null)
        {
            label = l;
            data = d;
            data2 = d2;
            Invalidate();
        }

        public void SetCurrentTime(int t)
        {
            currentTime = Math.Max(0,Math.Min(t, data.Length-1));
            Invalidate();
        }

        private void CatGraph_Paint(object sender, PaintEventArgs e)
        {
            int numPoints = data == null ? 0 : data.Length;

            if (numPoints == 0)
                return;

            Pen pen = new Pen(Color.Blue);
            Pen pen2 = new Pen(Color.Red);
            Brush brush = new SolidBrush(Color.Black);

            float minVal = data[0];
            float maxVal = data[0];
            for (int i = 1; i < numPoints; i++)
            {
                minVal = Math.Min(minVal, data[i]);
                maxVal = Math.Max(maxVal, data[i]);
                if (data2 != null)
                {
                    minVal = Math.Min(minVal, data2[i]);
                    maxVal = Math.Max(maxVal, data2[i]);
                }
            }

            float yScale = (minVal == maxVal) ? 0 : ((float)Height)/(maxVal + 2 - minVal);
            float xScale = ((float)Width) / numPoints;

            e.Graphics.DrawString(label + ":" + maxVal, Control.DefaultFont, brush, new Point(5, 5));
            Point p1 = new Point(), p2 = new Point();
            for (int i = 0; i < numPoints; i++)
            {
                p1 = new Point((int)(i * xScale), Height - 1 - (int)(data[i] * yScale));
                if (i > 0)
                    e.Graphics.DrawLine(pen, p2, p1);
                p2 = p1;
            }
            if (data2 != null)
            {
                p1 = new Point();
                p2 = new Point();
                for (int i = 0; i < numPoints; i++)
                {
                    p1 = new Point((int)(i * xScale), Height - 1 - (int)(data2[i] * yScale));
                    if (i > 0)
                        e.Graphics.DrawLine(pen2, p2, p1);
                    p2 = p1;
                }
            }
            p1.X = p2.X = (int)(currentTime*xScale);
            p1.Y = 0; p2.Y = Height;
            e.Graphics.DrawLine(pen, p2, p1);

            int currentVal = data[currentTime];
            e.Graphics.DrawString("" + currentVal, Control.DefaultFont, brush, new Point(5, Height -25));
        }
    }
}
