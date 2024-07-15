using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Serialization;

namespace GradedTask
{
    public partial class Form1 : Form
    {
        private DirectBitmap drawingBitmap = new DirectBitmap(800, 600);
        private Point lastPoint;
        private bool isMouseDown = false;
        private Color currentPenColor = Color.Black;

        public Color CurrentColor { get; private set; }

        private Rectangle HandleRectangle;
        private bool _isResizing = false;
        private Point _clickPosition;
        private Size _originalSize;
        public bool isSelecting = false;
        private Point selectionStart;
        public Rectangle selectionRect;
        private bool selectToolIsActive = false;
        private Point _selectionStart;
        private bool lineToolIsActive = false;
        public float zoomLevel = 1.02f;
        private ITool Tool;
        private Rectangle _selectionRect;
        public Form1()
        {
            InitializeComponent();

            currentPenColor = canvasControl1.currentPenColor;
            canvasControl1.CanvasBitmap = drawingBitmap.Bitmap;
            canvasControl1.isSelecting = SelectToolIsActive;
            canvasControl1.MouseMove += Canvas_MouseMove;
            statusCursorPosition.Text = $"Position: 0, 0                 Size: {canvasControl1.CanvasBitmap.Width}x{canvasControl1.CanvasBitmap.Height}";
            canvasControl1.MouseWheel += new MouseEventHandler(CanvasControl_MouseWheel);
            this.Load += (s, e) => canvasControl1.Focus();
            SubscribeToZoomEvents();    
        }

        private void ZoomIn()
        {
            zoomLevel *= 1.02f;
            if (Tool is SelectionTool selectionTool)
            {
                selectionTool.zoomLevel = zoomLevel;
            }
            Zoom();
        }

        private void ZoomOut()
        {
            zoomLevel /= 1.02f;
            if (Tool is SelectionTool selectionTool)
            {
                selectionTool.zoomLevel = zoomLevel;
            }
            Zoom();
        }

        private void Zoom()
        {
            Size = new Size((int)(drawingBitmap.Width * zoomLevel), (int)(drawingBitmap.Height * zoomLevel));

            AutoScrollMinSize = new Size(drawingBitmap.Width, drawingBitmap.Height);

            Invalidate();
        }

        private void SubscribeToZoomEvents()
        {
            MouseWheel += CanvasControl_MouseWheel;
            MouseEnter += CanvasControl_mouseEnter;
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


        public bool SelectToolIsActive
        {
            get { return selectToolIsActive; }
            set
            {
                selectToolIsActive = value;
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Bitmap Image|*.bmp|PNG Image|*.png|Jpeg Image|*.jpg";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    drawingBitmap.Bitmap.Save(saveDialog.FileName);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "Image files (*.bmp, *.png, *.jpg, *.jpeg)|*.bmp;*.png;*.jpg*.jpeg";
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    drawingBitmap.Dispose();
                    Bitmap tmp = new Bitmap(openDialog.FileName);
                    drawingBitmap = new DirectBitmap(tmp.Width, tmp.Height);
                    canvasControl1.CanvasBitmap = drawingBitmap.Bitmap;
                    canvasControl1.Size = new Size(drawingBitmap.Width, drawingBitmap.Height);
                }
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (lineToolIsActive && e.Button == MouseButtons.Left)
            {
                lastPoint = e.Location;
                isMouseDown = true;
            }
            if (SelectToolIsActive && e.Button == MouseButtons.Left)
            {
                selectionStart = e.Location;
                isSelecting = true;
                canvasControl1.isDrawing = false;
            }
            if (e.Button == MouseButtons.Left)
            {
                if (HandleRectangle.Contains(e.Location))
                {
                    _isResizing = true;
                    _clickPosition = e.Location;
                    _originalSize = canvasControl1.Size;
                    lastPoint = e.Location;
                    isMouseDown = true;
                }
                else
                {
                    lastPoint = e.Location;
                    isMouseDown = true;
                }
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            statusCursorPosition.Text = $"Position: {e.X}, {e.Y}";
            if (_isResizing)
            {
                int widthChange = e.X - _clickPosition.X;
                int heightChange = e.Y - _clickPosition.Y;
                canvasControl1.Size = new Size(_originalSize.Width + widthChange, _originalSize.Height + heightChange);
                canvasControl1.Invalidate();
            }
            if (isSelecting)
            {
                canvasControl1.isDrawing = false;
                canvasControl1.SelectionRect = new Rectangle(
                    Math.Min(e.X, selectionStart.X),
                    Math.Min(e.Y, selectionStart.Y),
                    Math.Abs(e.X - selectionStart.X),
                    Math.Abs(e.Y - selectionStart.Y));
                canvasControl1.Invalidate();
            }
            if (lineToolIsActive && isMouseDown)
            {
                using (Graphics g = Graphics.FromImage(drawingBitmap.Bitmap))
                {
                    g.DrawLine(new Pen(currentPenColor, 1), lastPoint, e.Location);
                }
                canvasControl1.Invalidate();
            }
            else if (isMouseDown && !SelectToolIsActive)
            {
                using (Graphics g = Graphics.FromImage(drawingBitmap.Bitmap))
                {
                    g.DrawLine(new Pen(currentPenColor, 1), lastPoint, e.Location);
                    lastPoint = e.Location;
                }
                canvasControl1.Invalidate();
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            _isResizing = false;
            if (isSelecting)
            {
                _selectionRect = canvasControl1.SelectionRect;
                isSelecting = false;
                canvasControl1.isDrawing = false;
            }
            if (lineToolIsActive)
            {
                using (Graphics g = Graphics.FromImage(drawingBitmap.Bitmap))
                {
                    g.DrawLine(new Pen(currentPenColor, 1), lastPoint, e.Location);
                }
                canvasControl1.Invalidate();

            }
        }




        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusCursorPosition.Text = $"Position: 0, 0                 Size: {canvasControl1.CanvasBitmap.Width}x{canvasControl1.CanvasBitmap.Height}";
            lineToolIsActive = false;
            selectToolIsActive = false;
            canvasControl1.currentPenColor = Color.Black;
        }

        private void editColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentPenColor = colorDialog1.Color;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var newImageDialog = new NewImageForm())
            {
                newImageDialog.SetDefaultValues(800, 600, Color.White);
                if (newImageDialog.ShowDialog() == DialogResult.OK)
                {
                    int newWidth = newImageDialog.ImageWidth;
                    int newHeight = newImageDialog.ImageHeight;
                    Color newBackground = newImageDialog.BackgroundColor;

                    if (newWidth <= 0 || newHeight <= 0)
                    {
                        MessageBox.Show("Width and Height must be greater than zero.");
                        return;
                    }

                    drawingBitmap.Dispose();
                    drawingBitmap = new DirectBitmap(newWidth, newHeight);
                    using (Graphics g = Graphics.FromImage(drawingBitmap.Bitmap))
                    {
                        g.Clear(newBackground);
                    }
                    canvasControl1.CanvasBitmap = drawingBitmap.Bitmap;


                    canvasControl1.Size = new Size(drawingBitmap.Width, drawingBitmap.Height);
                    canvasControl1.Invalidate(); 
                }
            }
        }

        private void Pen_click(object sender, EventArgs e)
        {
            lineToolIsActive = false;
            canvasControl1.SelectToolIsActive = false;
            
        }

        private void SelectClick(object sender, EventArgs e)
        {
            canvasControl1.SelectToolIsActive = !canvasControl1.SelectToolIsActive;
            if (!canvasControl1.SelectToolIsActive)
            {
                canvasControl1.SelectionRect = Rectangle.Empty;
                canvasControl1.Invalidate(); 
            }
        }

        private void Line_Click(object sender, EventArgs e)
        {
            lineToolIsActive = true;
            canvasControl1.SelectToolIsActive = false;
        }

        private void invertColorsToolStripMenuItem_click(object sender, EventArgs e)
        {
            Rectangle selection = _selectionRect;
            if (selection != null)
            {
                for (int y = 0; (y <= (selection.Height + selection.Y)); y++)
                {
                    for (int x = 0; (x <= (selection.Width + selection.X)); x++)
                    {
                        Color original = drawingBitmap.GetPixel(x, y);
                        Color inv;
                        inv = Color.FromArgb(255, (255 - original.R), (255 - original.G), (255 - original.B));
                        drawingBitmap.SetPixel(x, y, inv);
                    }
                }
                Invalidate();
            }
            else
            {
                for (int y = 0; (y <= (drawingBitmap.Height)); y++)
                {
                    for (int x = 0; (x <= (drawingBitmap.Width)); x++)
                    {
                        Color original = drawingBitmap.GetPixel(x, y);
                        Color inv;
                        inv = Color.FromArgb(255, (255 - original.R), (255 - original.G), (255 - original.B));
                        drawingBitmap.SetPixel(x, y, inv);
                    }
                }
                Invalidate();
            }
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            // Cast the sender to a Button to access its properties.
            Button colorButton = sender as Button;
            if (colorButton != null)
            {
                currentPenColor = colorButton.BackColor;
                
            }
        }

        private void CanvasControl_mouseEnter(object sender, EventArgs e)
        {
            Focus();
        }
    }
}
