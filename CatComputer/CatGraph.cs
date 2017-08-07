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
        public string label;

        public CatGraph()
        {
            InitializeComponent();
        }

        public void ShowData(string l, int[] d)
        {
            label = l;
            data = d;
            Invalidate();
        }

        private void CatGraph_Paint(object sender, PaintEventArgs e)
        {
            int numPoints = data == null ? 0 : data.Length;

            if (numPoints == 0)
                return;

            Pen pen = new Pen(Color.Blue);
            Brush brush = new SolidBrush(Color.Black);

            float minVal = data[0];
            float maxVal = data[0];
            for (int i = 1; i < numPoints; i++)
            {
                minVal = Math.Min(minVal, data[i]);
                maxVal = Math.Max(maxVal, data[i]);
            }

            float yScale = (minVal == maxVal) ? 0 : ((float)Height)/(maxVal - minVal);
            float xScale = ((float)Width) / numPoints;

            e.Graphics.DrawString(label + ":" + maxVal, Control.DefaultFont, brush, new Point(5, 5));
            Point p1, p2 = new Point();
            for (int i = 0; i < numPoints; i++)
            {
                p1 = new Point((int)(i * xScale), Height - 1 - (int)(data[i] * yScale));
                if (i > 0)
                    e.Graphics.DrawLine(pen, p2, p1);
                p2 = p1;
            }
        }
    }
}
