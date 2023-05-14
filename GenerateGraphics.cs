using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Order_Management
{
    public class GenerateGraphics : Control
    {
        private Dictionary<string, int> categoryCounts;

        public GenerateGraphics(Dictionary<string, int> categoryCounts)
        {
            this.categoryCounts = categoryCounts;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (categoryCounts == null || categoryCounts.Count == 0)
            {
                return;
            }
            List<Brush> brushes = new List<Brush> { Brushes.Red, Brushes.Green, Brushes.Blue, Brushes.Yellow, Brushes.Orange, Brushes.Purple };

            int marginLeft = 10;
            int marginTop = 10;
            int marginBottom = 40; 
            int barSpacing = 5;

            int barWidth = (Width - marginLeft * 2 - barSpacing * (categoryCounts.Count - 1)) / categoryCounts.Count;
            int maxCount = categoryCounts.Values.Max();

            int i = 0;
            foreach (var category in categoryCounts)
            {
                int barHeight = (int)((float)category.Value / maxCount * (Height - marginTop - marginBottom));
                e.Graphics.FillRectangle(brushes[i % brushes.Count], marginLeft + i * (barWidth + barSpacing), Height - marginBottom - barHeight, barWidth, barHeight);
                e.Graphics.DrawString(category.Key, DefaultFont, Brushes.Black, marginLeft + i * (barWidth + barSpacing), Height - marginBottom + 5);
                i++;
            }
        }
    }

}
