namespace GradedTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem = new ToolStripMenuItem();
            colorsToolStripMenuItem = new ToolStripMenuItem();
            editColorsToolStripMenuItem = new ToolStripMenuItem();
            invertColorsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusCursorPosition = new ToolStripStatusLabel();
            statusImageSize = new ToolStripStatusLabel();
            panel1 = new Panel();
            button24 = new Button();
            canvasControl1 = new CanvasControl();
            Buttonpanel = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            Line = new Button();
            Select = new Button();
            Pen = new Button();
            button1 = new Button();
            Current = new Button();
            Black = new Button();
            button23 = new Button();
            black2 = new Button();
            DarkGrey1 = new Button();
            button22 = new Button();
            DarkGrey2 = new Button();
            button2 = new Button();
            button21 = new Button();
            button3 = new Button();
            button20 = new Button();
            button4 = new Button();
            button19 = new Button();
            button5 = new Button();
            button18 = new Button();
            button6 = new Button();
            button16 = new Button();
            button7 = new Button();
            button17 = new Button();
            button9 = new Button();
            button14 = new Button();
            button15 = new Button();
            button8 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button10 = new Button();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            Buttonpanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, imageToolStripMenuItem, colorsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(982, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, printToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(48, 24);
            menuToolStripMenuItem.Text = "File";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(247, 26);
            newToolStripMenuItem.Text = "New          ";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(247, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(247, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(247, 26);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(247, 26);
            printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(247, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(51, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(217, 26);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(217, 26);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(217, 26);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(217, 26);
            selectAllToolStripMenuItem.Text = "Select All";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(58, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(68, 24);
            imageToolStripMenuItem.Text = "Image";
            // 
            // colorsToolStripMenuItem
            // 
            colorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editColorsToolStripMenuItem, invertColorsToolStripMenuItem });
            colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            colorsToolStripMenuItem.Size = new Size(70, 24);
            colorsToolStripMenuItem.Text = "Colors";
            // 
            // editColorsToolStripMenuItem
            // 
            editColorsToolStripMenuItem.Name = "editColorsToolStripMenuItem";
            editColorsToolStripMenuItem.Size = new Size(235, 26);
            editColorsToolStripMenuItem.Text = "Edit Colors...";
            editColorsToolStripMenuItem.Click += editColorsToolStripMenuItem_Click;
            // 
            // invertColorsToolStripMenuItem
            // 
            invertColorsToolStripMenuItem.Name = "invertColorsToolStripMenuItem";
            invertColorsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            invertColorsToolStripMenuItem.Size = new Size(235, 26);
            invertColorsToolStripMenuItem.Text = "Invert Colors";
            invertColorsToolStripMenuItem.Click += invertColorsToolStripMenuItem_click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(58, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys = Keys.F12;
            aboutToolStripMenuItem.Size = new Size(170, 26);
            aboutToolStripMenuItem.Text = "about";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusCursorPosition, statusImageSize });
            statusStrip1.Location = new Point(0, 727);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(982, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStripBar";
            // 
            // statusCursorPosition
            // 
            statusCursorPosition.Name = "statusCursorPosition";
            statusCursorPosition.Size = new Size(68, 20);
            statusCursorPosition.Text = "Position";
            // 
            // statusImageSize
            // 
            statusImageSize.Name = "statusImageSize";
            statusImageSize.Size = new Size(0, 20);
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.Controls.Add(button24);
            panel1.Controls.Add(canvasControl1);
            panel1.Controls.Add(Buttonpanel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Current);
            panel1.Controls.Add(Black);
            panel1.Controls.Add(button23);
            panel1.Controls.Add(black2);
            panel1.Controls.Add(DarkGrey1);
            panel1.Controls.Add(button22);
            panel1.Controls.Add(DarkGrey2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button21);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button20);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button19);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button18);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button16);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button17);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button14);
            panel1.Controls.Add(button15);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button10);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 699);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // button24
            // 
            button24.BackColor = Color.Purple;
            button24.Location = new Point(620, 36);
            button24.Name = "button24";
            button24.Size = new Size(27, 27);
            button24.TabIndex = 25;
            button24.UseVisualStyleBackColor = false;
            button24.Click += ColorButton_Click;
            // 
            // canvasControl1
            // 
            canvasControl1.AutoScroll = true;
            canvasControl1.BackColor = Color.White;
            canvasControl1.CanvasBitmap = (Bitmap)resources.GetObject("canvasControl1.CanvasBitmap");
            canvasControl1.Location = new Point(121, 73);
            canvasControl1.MinimumSize = new Size(800, 600);
            canvasControl1.Name = "canvasControl1";
            canvasControl1.SelectionRect = new Rectangle(0, 0, 0, 0);
            canvasControl1.SelectToolIsActive = false;
            canvasControl1.Size = new Size(800, 600);
            canvasControl1.TabIndex = 4;
            canvasControl1.TabStop = true;
            canvasControl1.MouseDown += Canvas_MouseDown;
            canvasControl1.MouseEnter += CanvasControl_mouseEnter;
            canvasControl1.MouseMove += Canvas_MouseMove;
            canvasControl1.MouseUp += Canvas_MouseUp;
            // 
            // Buttonpanel
            // 
            Buttonpanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Buttonpanel.Controls.Add(flowLayoutPanel1);
            Buttonpanel.Controls.Add(Line);
            Buttonpanel.Controls.Add(Select);
            Buttonpanel.Controls.Add(Pen);
            Buttonpanel.Location = new Point(0, 0);
            Buttonpanel.Name = "Buttonpanel";
            Buttonpanel.Size = new Size(115, 673);
            Buttonpanel.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Location = new Point(112, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 66);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(803, 64);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // Line
            // 
            Line.Location = new Point(12, 86);
            Line.Name = "Line";
            Line.Size = new Size(94, 29);
            Line.TabIndex = 2;
            Line.Text = "Line";
            Line.UseVisualStyleBackColor = true;
            Line.Click += Line_Click;
            // 
            // Select
            // 
            Select.Location = new Point(12, 51);
            Select.Name = "Select";
            Select.Size = new Size(94, 29);
            Select.TabIndex = 1;
            Select.Text = "Select";
            Select.UseVisualStyleBackColor = true;
            Select.Click += SelectClick;
            // 
            // Pen
            // 
            Pen.Location = new Point(12, 16);
            Pen.Name = "Pen";
            Pen.Size = new Size(94, 29);
            Pen.TabIndex = 0;
            Pen.Text = "Pen";
            Pen.UseVisualStyleBackColor = true;
            Pen.Click += Pen_click;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.Location = new Point(620, 3);
            button1.Name = "button1";
            button1.Size = new Size(27, 27);
            button1.TabIndex = 25;
            button1.UseVisualStyleBackColor = false;
            button1.Click += ColorButton_Click;
            // 
            // Current
            // 
            Current.Location = new Point(135, 5);
            Current.Name = "Current";
            Current.Size = new Size(50, 50);
            Current.TabIndex = 5;
            Current.UseVisualStyleBackColor = true;
            // 
            // Black
            // 
            Black.BackColor = Color.Black;
            Black.Location = new Point(191, 5);
            Black.Name = "Black";
            Black.Size = new Size(27, 27);
            Black.TabIndex = 6;
            Black.UseVisualStyleBackColor = false;
            Black.Click += ColorButton_Click;
            // 
            // button23
            // 
            button23.BackColor = Color.FromArgb(0, 0, 192);
            button23.Location = new Point(587, 36);
            button23.Name = "button23";
            button23.Size = new Size(27, 27);
            button23.TabIndex = 20;
            button23.UseVisualStyleBackColor = false;
            button23.Click += ColorButton_Click;
            // 
            // black2
            // 
            black2.BackColor = Color.Black;
            black2.Location = new Point(191, 38);
            black2.Name = "black2";
            black2.Size = new Size(27, 27);
            black2.TabIndex = 7;
            black2.UseVisualStyleBackColor = false;
            black2.Click += ColorButton_Click;
            // 
            // DarkGrey1
            // 
            DarkGrey1.BackColor = Color.FromArgb(64, 64, 64);
            DarkGrey1.Location = new Point(224, 5);
            DarkGrey1.Name = "DarkGrey1";
            DarkGrey1.Size = new Size(27, 27);
            DarkGrey1.TabIndex = 8;
            DarkGrey1.UseVisualStyleBackColor = false;
            DarkGrey1.Click += ColorButton_Click;
            // 
            // button22
            // 
            button22.BackColor = Color.FromArgb(0, 0, 192);
            button22.Location = new Point(587, 3);
            button22.Name = "button22";
            button22.Size = new Size(27, 27);
            button22.TabIndex = 24;
            button22.UseVisualStyleBackColor = false;
            button22.Click += ColorButton_Click;
            // 
            // DarkGrey2
            // 
            DarkGrey2.BackColor = Color.FromArgb(64, 64, 64);
            DarkGrey2.Location = new Point(224, 38);
            DarkGrey2.Name = "DarkGrey2";
            DarkGrey2.Size = new Size(27, 27);
            DarkGrey2.TabIndex = 9;
            DarkGrey2.UseVisualStyleBackColor = false;
            DarkGrey2.Click += ColorButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Location = new Point(257, 5);
            button2.Name = "button2";
            button2.Size = new Size(27, 27);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = false;
            button2.Click += ColorButton_Click;
            // 
            // button21
            // 
            button21.BackColor = Color.DodgerBlue;
            button21.Location = new Point(554, 36);
            button21.Name = "button21";
            button21.Size = new Size(27, 27);
            button21.TabIndex = 20;
            button21.UseVisualStyleBackColor = false;
            button21.Click += ColorButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Location = new Point(257, 38);
            button3.Name = "button3";
            button3.Size = new Size(27, 27);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = false;
            button3.Click += ColorButton_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.DodgerBlue;
            button20.Location = new Point(554, 3);
            button20.Name = "button20";
            button20.Size = new Size(27, 27);
            button20.TabIndex = 20;
            button20.UseVisualStyleBackColor = false;
            button20.Click += ColorButton_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Maroon;
            button4.Location = new Point(290, 5);
            button4.Name = "button4";
            button4.Size = new Size(27, 27);
            button4.TabIndex = 9;
            button4.UseVisualStyleBackColor = false;
            button4.Click += ColorButton_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.Cyan;
            button19.Location = new Point(521, 36);
            button19.Name = "button19";
            button19.Size = new Size(27, 27);
            button19.TabIndex = 23;
            button19.UseVisualStyleBackColor = false;
            button19.Click += ColorButton_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Maroon;
            button5.Location = new Point(290, 38);
            button5.Name = "button5";
            button5.Size = new Size(27, 27);
            button5.TabIndex = 12;
            button5.UseVisualStyleBackColor = false;
            button5.Click += ColorButton_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.Cyan;
            button18.Location = new Point(521, 3);
            button18.Name = "button18";
            button18.Size = new Size(27, 27);
            button18.TabIndex = 22;
            button18.UseVisualStyleBackColor = false;
            button18.Click += ColorButton_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Location = new Point(323, 5);
            button6.Name = "button6";
            button6.Size = new Size(27, 27);
            button6.TabIndex = 13;
            button6.UseVisualStyleBackColor = false;
            button6.Click += ColorButton_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(0, 192, 0);
            button16.Location = new Point(488, 38);
            button16.Name = "button16";
            button16.Size = new Size(27, 27);
            button16.TabIndex = 20;
            button16.UseVisualStyleBackColor = false;
            button16.Click += ColorButton_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Red;
            button7.Location = new Point(323, 38);
            button7.Name = "button7";
            button7.Size = new Size(27, 27);
            button7.TabIndex = 9;
            button7.UseVisualStyleBackColor = false;
            button7.Click += ColorButton_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(0, 192, 0);
            button17.Location = new Point(488, 5);
            button17.Name = "button17";
            button17.Size = new Size(27, 27);
            button17.TabIndex = 21;
            button17.UseVisualStyleBackColor = false;
            button17.Click += ColorButton_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 128, 0);
            button9.Location = new Point(356, 5);
            button9.Name = "button9";
            button9.Size = new Size(27, 27);
            button9.TabIndex = 15;
            button9.UseVisualStyleBackColor = false;
            button9.Click += ColorButton_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.Lime;
            button14.Location = new Point(455, 38);
            button14.Name = "button14";
            button14.Size = new Size(27, 27);
            button14.TabIndex = 18;
            button14.UseVisualStyleBackColor = false;
            button14.Click += ColorButton_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.Lime;
            button15.Location = new Point(455, 5);
            button15.Name = "button15";
            button15.Size = new Size(27, 27);
            button15.TabIndex = 19;
            button15.UseVisualStyleBackColor = false;
            button15.Click += ColorButton_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 128, 0);
            button8.Location = new Point(356, 38);
            button8.Name = "button8";
            button8.Size = new Size(27, 27);
            button8.TabIndex = 14;
            button8.UseVisualStyleBackColor = false;
            button8.Click += ColorButton_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Gold;
            button11.Location = new Point(389, 5);
            button11.Name = "button11";
            button11.Size = new Size(27, 27);
            button11.TabIndex = 16;
            button11.UseVisualStyleBackColor = false;
            button11.Click += ColorButton_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Yellow;
            button12.Location = new Point(422, 38);
            button12.Name = "button12";
            button12.Size = new Size(27, 27);
            button12.TabIndex = 17;
            button12.UseVisualStyleBackColor = false;
            button12.Click += ColorButton_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Yellow;
            button13.Location = new Point(422, 5);
            button13.Name = "button13";
            button13.Size = new Size(27, 27);
            button13.TabIndex = 9;
            button13.UseVisualStyleBackColor = false;
            button13.Click += ColorButton_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Gold;
            button10.Location = new Point(389, 38);
            button10.Name = "button10";
            button10.Size = new Size(27, 27);
            button10.TabIndex = 9;
            button10.UseVisualStyleBackColor = false;
            button10.Click += ColorButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(982, 753);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1000, 800);
            Name = "Form1";
            Text = "MS Paint 2024";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            Buttonpanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem colorsToolStripMenuItem;
        private ToolStripMenuItem editColorsToolStripMenuItem;
        private ToolStripMenuItem invertColorsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusCursorPosition;
        private ToolStripStatusLabel statusImageSize;
        private Panel panel1;
        private ColorDialog colorDialog1;
        private Panel Buttonpanel;
        private Button Select;
        private Button Pen;
        private Button Line;
        private CanvasControl canvasControl1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Black;
        private Button Current;
        private Button DarkGrey1;
        private Button black2;
        private Button DarkGrey2;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button23;
        private Button button22;
        private Button button21;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button24;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
