using GradedTask;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace GradedTask
{
    public interface ITool
    {
        void MouseDown(object sender, MouseEventArgs e);
        void MouseMove(object sender, MouseEventArgs e);
        void MouseUp(object sender, MouseEventArgs e);
    }
    
    public class PenTool : ITool
    {
        private Point lastPoint;
        public bool isDrawing = false;

        public void MouseDown(object sender, MouseEventArgs e)
        {
            CanvasControl canvas = sender as CanvasControl;
            if (canvas != null)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            CanvasControl canvas = sender as CanvasControl;
            if (isDrawing && canvas != null)
            {
                using (Graphics g = Graphics.FromImage(canvas.drawingBitmap.Bitmap))
                {
                    g.DrawLine(new Pen(canvas.currentPenColor), lastPoint, e.Location);
                }
                lastPoint = e.Location;
                canvas.Invalidate();
            }
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }




public class SelectionTool : ITool
{
    private Point startPoint;
    private bool isSelecting = false;

    public float zoomLevel { get; set; }

    public void MouseDown(object sender, MouseEventArgs e)
    {
        CanvasControl canvas = sender as CanvasControl;
        if (canvas != null)
        {
            isSelecting = true;
            startPoint = e.Location;
        }
    }

    public void MouseMove(object sender, MouseEventArgs e)
    {
        CanvasControl canvas = sender as CanvasControl;
        if (isSelecting && canvas != null)
        {
            
            canvas.isDrawing = false;

            if (canvas != null)
            {
                canvas.SelectionRect = new Rectangle(
                    Math.Min(startPoint.X, e.X),
                    Math.Min(startPoint.Y, e.Y),
                    Math.Abs(startPoint.X - e.X),
                    Math.Abs(startPoint.Y - e.Y));
                canvas.Invalidate();
            }
        }
    }

    public void MouseUp(object sender, MouseEventArgs e)
    {
        isSelecting = false;
    }
}

    // Implement the LineTool
    public class LineTool : ITool
    {
        public Point startPoint { get; set; }
        public Point endPoint { get; set; }
        private Color lineColor = Color.Black;
        private bool isDrawing = false;

        public LineTool(Point startPoint, Point endPoint,Color color)
        {
            startPoint = startPoint;
            endPoint = endPoint;
            lineColor = color;

            lineColor = color;
        }

        public void MouseDown(object sender, MouseEventArgs e)
        {
            CanvasControl canvas = sender as CanvasControl;
            if (canvas != null)
            {
                startPoint = e.Location;
                isDrawing = true;
            }
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                CanvasControl canvas = sender as CanvasControl;
                if (canvas != null)
                {
                    using (Graphics g = Graphics.FromImage(canvas.CanvasBitmap))
                    {
                        g.DrawLine(new Pen(lineColor), startPoint, e.Location);
                    }
                    canvas.Invalidate();
                }
                isDrawing = false;                  // Optionally, update the canvas here if you want a line preview
            }
        }
       

        //https://stackoverflow.com/questions/62651042/how-to-implement-bresenhams-line-algorithm-in-c-when-trying-to-draw-a-line-in-b
        private void DrawLine(DirectBitmap bmp, int x, int y, int x2, int y2, Color color)
        {
            int w = x2 - x;
            int h = y2 - y;
            int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;

            if (w < 0) dx1 = -1; else if (w > 0) dx1 = 1;
            if (h < 0) dy1 = -1; else if (h > 0) dy1 = 1;
            if (w < 0) dx2 = -1; else if (w > 0) dx2 = 1;

            int longest = Math.Abs(w);
            int shortest = Math.Abs(h);

            if (!(longest > shortest))
            {
                longest = Math.Abs(h);
                shortest = Math.Abs(w);
                if (h < 0) dy2 = -1; else if (h > 0) dy2 = 1;
                dx2 = 0;
            }

            int numerator = longest >> 1;
            for (int i = 0; i <= longest; i++)
            {
                bmp.SetPixel(x, y, color);
                numerator += shortest;
                if (!(numerator < longest))
                {
                    numerator -= longest;
                    x += dx1;
                    y += dy1;
                }
                else
                {
                    x += dx2;
                    y += dy2;
                }
            }
        }
    }
}
 