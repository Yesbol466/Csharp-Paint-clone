using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedTask
{
    public class DrawAction
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Color Color { get; set; }
        public float Thickness { get; set; }

        public DrawAction(Point startPoint, Point endPoint, Color color, float thickness)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            Color = color;
            Thickness = thickness;
        }

        public void ExecuteAction(DirectBitmap directBitmap)
        {
            using (var graphics = Graphics.FromImage(directBitmap.Bitmap))
            {
                using (var pen = new Pen(Color, Thickness))
                {
                    graphics.DrawLine(pen, StartPoint, EndPoint);
                }
            }
        }
    }
}
