using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradedTask
{
    public partial class NewImageForm : Form
    {
        public int ImageWidth => (int)widthNumericUpDown.Value;
        public int ImageHeight => (int)heightNumericUpDown.Value;
        public Color BackgroundColor { get; private set; } = Color.White;
        public NewImageForm()
        {
            InitializeComponent();
            SetDefaultValues(800, 600, Color.White);

        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (backgroundColorDialog.ShowDialog() == DialogResult.OK)
            {
                BackgroundColor = backgroundColorDialog.Color;
                backgroundButton.BackColor = BackgroundColor;
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        internal void SetDefaultValues(int defaultWidth, int defaultHeight, Color defaultColor)
        {
            widthNumericUpDown.Minimum = 1;
            widthNumericUpDown.Maximum = 10000;
            heightNumericUpDown.Minimum = 1;
            heightNumericUpDown.Maximum = 10000;

            // Now it's safe to set the default values
            widthNumericUpDown.Value = defaultWidth;
            heightNumericUpDown.Value = defaultHeight;

            // Set the default background color
            BackgroundColor = defaultColor;
            // Update the color preview button
            backgroundButton.BackColor = defaultColor;
        }

    }
}
