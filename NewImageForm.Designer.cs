namespace GradedTask
{
    partial class NewImageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Width = new Label();
            widthNumericUpDown = new NumericUpDown();
            Height = new Label();
            heightNumericUpDown = new NumericUpDown();
            backgroundButton = new Button();
            backGroundLabel = new Label();
            backgroundColorDialog = new ColorDialog();
            newButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)widthNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heightNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // Width
            // 
            Width.AutoSize = true;
            Width.Location = new Point(63, 55);
            Width.Name = "Width";
            Width.Size = new Size(211, 20);
            Width.TabIndex = 0;
            Width.Text = "Width:                                  px";
            // 
            // widthNumericUpDown
            // 
            widthNumericUpDown.Location = new Point(118, 53);
            widthNumericUpDown.Name = "widthNumericUpDown";
            widthNumericUpDown.Size = new Size(132, 27);
            widthNumericUpDown.TabIndex = 1;
            // 
            // Height
            // 
            Height.AutoSize = true;
            Height.Location = new Point(61, 87);
            Height.Name = "Height";
            Height.Size = new Size(213, 20);
            Height.TabIndex = 2;
            Height.Text = "Height:                                 px";
            // 
            // heightNumericUpDown
            // 
            heightNumericUpDown.Location = new Point(118, 87);
            heightNumericUpDown.Name = "heightNumericUpDown";
            heightNumericUpDown.Size = new Size(132, 27);
            heightNumericUpDown.TabIndex = 3;
            // 
            // backgroundButton
            // 
            backgroundButton.BackColor = Color.White;
            backgroundButton.Location = new Point(118, 120);
            backgroundButton.Name = "backgroundButton";
            backgroundButton.Size = new Size(132, 29);
            backgroundButton.TabIndex = 4;
            backgroundButton.UseVisualStyleBackColor = false;
            backgroundButton.Click += backgroundButton_Click;
            // 
            // backGroundLabel
            // 
            backGroundLabel.AutoSize = true;
            backGroundLabel.Location = new Point(16, 124);
            backGroundLabel.Name = "backGroundLabel";
            backGroundLabel.Size = new Size(96, 20);
            backGroundLabel.TabIndex = 5;
            backGroundLabel.Text = "Background";
            // 
            // newButton
            // 
            newButton.Location = new Point(86, 205);
            newButton.Name = "newButton";
            newButton.Size = new Size(94, 29);
            newButton.TabIndex = 6;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(206, 205);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // NewImageForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 304);
            Controls.Add(cancelButton);
            Controls.Add(newButton);
            Controls.Add(backGroundLabel);
            Controls.Add(backgroundButton);
            Controls.Add(heightNumericUpDown);
            Controls.Add(Height);
            Controls.Add(widthNumericUpDown);
            Controls.Add(Width);
            Name = "NewImageForm";
            Text = "NewImageForm";
            ((System.ComponentModel.ISupportInitialize)widthNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)heightNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Width;
        private NumericUpDown widthNumericUpDown;
        private Label Height;
        private NumericUpDown heightNumericUpDown;
        private Button backgroundButton;
        private Label backGroundLabel;
        private ColorDialog backgroundColorDialog;
        private Button newButton;
        private Button cancelButton;
    }
}