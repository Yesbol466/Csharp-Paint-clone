using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace GradedTask
{
    public class CanvasControl : Panel
    {
        public DirectBitmap drawingBitmap;
        public bool isDrawing = false;
        private Point lastPoint;
        private bool isResizing = false;
        private Point clickOffset;
        private const int handleSize = 10; 
        private Rectangle bottomRightHandle => new Rectangle(this.Width - handleSize, this.Height - handleSize, handleSize, handleSize);
        private Rectangle selectionRect;
        public float ZoomFactor = 1.0f;
        public bool isSelecting = true;
        public List<DrawAction> drawActions = new List<DrawAction>();
        public Color currentPenColor = Color.Black;
        private Point selectionStart;
        private bool selectToolIsActive = false;
        private bool lineToolIsActive = false;
        private Point startPoint;
        private Point endPoint;
        private bool isLineDrawingActive = false;
        public float zoomLevel { get; set; } = 1.0f;
        private ITool Tool;
        public ITool ActiveTool { get; set; }

        public bool SelectToolIsActive
        {
            get { return selectToolIsActive; }
            set
            {
                selectToolIsActive = value;
                if (!selectToolIsActive)
                {
                    SelectionRect = Rectangle.Empty; 
                }
            }
        }
        public CanvasControl()
        {
            this.Size = new Size(800, 600);
            this.drawingBitmap = new DirectBitmap(800, 600);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.DoubleBuffered = true;
            this.TabStop = true;
            this.MouseWheel += CanvasControl_MouseWheel;
            this.MouseDown += CanvasControl_MouseDown;
            this.MouseMove += CanvasControl_MouseMove;
            this.MouseUp += CanvasControl_MouseUp;
        }

        public Rectangle SelectionRect
        {
            get { return selectionRect; }
            set
            {
                selectionRect = value;
                Invalidate();
            }
        }
        public Bitmap CanvasBitmap
        {
            get { return drawingBitmap.Bitmap; }
            set { drawingBitmap.ReplaceBitmap(value); }
        }
        public void CanvasControl_MouseWheel(object sender, MouseEventArgs e)
        {
            switch (e.Delta)
            {
                case > 0:
                    ZoomIn();
                    break;
                case < 0:
                    ZoomOut();
                    break;
            }
        }
        private void ZoomIn()
        {
            zoomLevel *= 1.02f;
            if (Tool is SelectionTool selectionTool)
            {
                selectionTool.zoomLevel = zoomLevel;
            }
            ApplyZoom();
        }

        private void ZoomOut()
        {
            zoomLevel /= 1.02f;
            if (Tool is SelectionTool selectionTool)
            {
                selectionTool.zoomLevel = zoomLevel;
            }
            ApplyZoom();
        }

        private void ApplyZoom()
        {
            Size = new Size((int)(drawingBitmap.Width * zoomLevel), (int)(drawingBitmap.Height * zoomLevel));

            AutoScrollMinSize = new Size(drawingBitmap.Width, drawingBitmap.Height);

            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
           
            if (drawingBitmap != null)
            {
                e.Graphics.DrawImageUnscaled(drawingBitmap.Bitmap, Point.Empty);
            }
            if (isSelecting && !SelectionRect.IsEmpty)
            {
                
                using (var pen = new Pen(Color.Blue) { DashStyle = DashStyle.Dot })
                {
                    e.Graphics.DrawRectangle(pen, SelectionRect);
                }
            }
            if (isLineDrawingActive)
            {
                e.Graphics.DrawLine(new Pen(currentPenColor, 1), startPoint, endPoint); 
            }
            DrawResizeHandles(e.Graphics);
        }

       

        private void CanvasControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }
            if (lineToolIsActive && e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isLineDrawingActive = true; 
            }
            if (SelectToolIsActive && e.Button == MouseButtons.Left)
            {
                selectionStart = e.Location;
                isSelecting = true;
                isDrawing = false;
            }
        }

        private void CanvasControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (drawActions.Count > 0)
                {
                    DrawAction lastAction = drawActions[drawActions.Count - 1];
                    lastAction.ExecuteAction(this.drawingBitmap);
                }
                Point currentPoint = e.Location;
                DrawAction action = new DrawAction(lastPoint, currentPoint, Color.Black, 1.0f);
                drawActions.Add(action);
                action.ExecuteAction(this.drawingBitmap);
                lastPoint = currentPoint;
                this.Invalidate();
            }
            if (isLineDrawingActive &&Tool is LineTool && e.Button == MouseButtons.Left)
            {   //redraw everything every time we calling 
                endPoint = e.Location;
                Invalidate();
            }
            if (isSelecting)
            { 
                SelectionRect = new Rectangle(
                    Math.Min(selectionStart.X, e.X),
                    Math.Min(selectionStart.Y, e.Y),
                    Math.Abs(e.X - selectionStart.X),
                    Math.Abs(e.Y - selectionStart.Y));
                isDrawing = false;
                Invalidate();
            }
        }

        private void CanvasControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                if (drawActions.Count > 0)
                {
                    DrawAction lastAction = drawActions[drawActions.Count - 1];
                    lastAction.ExecuteAction(this.drawingBitmap);
                }
                this.Invalidate();
            }
            if (Tool is LineTool)
            {   isSelecting = false; 
                isLineDrawingActive = false; 
                using (var graphics = Graphics.FromImage(drawingBitmap.Bitmap))
                {
                    using (var pen = new Pen(currentPenColor))
                    {
                        graphics.DrawLine(pen, startPoint, endPoint);
                    }
                }
            }
            if (isSelecting)
            {
                isSelecting = false;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && drawingBitmap != null)
            {
                drawingBitmap.Dispose();
            }
            base.Dispose(disposing);
        }

        private void DrawResizeHandles(Graphics graphics)
        {
            Brush resizeBrush = Brushes.Black;
            graphics.FillRectangle(resizeBrush, new Rectangle(Width - handleSize, Height - handleSize, handleSize, handleSize)); // Bottom-right
            graphics.FillRectangle(resizeBrush, new Rectangle(0, Height - handleSize, handleSize, handleSize)); // Bottom-left
            graphics.FillRectangle(resizeBrush, new Rectangle(Width - handleSize, 0, handleSize, handleSize)); // Top-right
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (bottomRightHandle.Contains(e.Location))
            {
                isResizing = true;
                clickOffset = new Point(e.X - this.Width, e.Y - this.Height);
                this.Cursor = Cursors.SizeNWSE;
            }
            if (SelectToolIsActive && e.Button == MouseButtons.Left)
            {
                isSelecting = true;
                selectionStart = e.Location;
            }
            if (lineToolIsActive && e.Button == MouseButtons.Left)
            {
                lastPoint = e.Location;
                isDrawing = true; // Start drawing
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (isResizing)
            {
                this.Width = e.X + clickOffset.X;
                this.Height = e.Y + clickOffset.Y;
                this.Invalidate();
            }
            else if (bottomRightHandle.Contains(e.Location))
            {
                this.Cursor = Cursors.SizeNWSE;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
            if (isSelecting)
            {
                selectionRect = new Rectangle(
                    Math.Min(selectionStart.X, e.X),
                    Math.Min(selectionStart.Y, e.Y),
                    Math.Abs(selectionStart.X - e.X),
                    Math.Abs(selectionStart.Y - e.Y));
                this.Invalidate(); 
            }
            if (isDrawing)
            {

                Graphics g = Graphics.FromImage(CanvasBitmap);
                g.DrawLine(new Pen(currentPenColor, 1), lastPoint, e.Location);
                lastPoint = e.Location;
                this.Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            isResizing = false;
            this.Cursor = Cursors.Default;
            if (isSelecting)
            {
                isSelecting = false;
                this.Invalidate();
            }
        }

    }
}
