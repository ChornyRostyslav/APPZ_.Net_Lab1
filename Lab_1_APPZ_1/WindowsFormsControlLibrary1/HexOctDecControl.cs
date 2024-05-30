using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public enum NumberFormat
    {
        Decimal,
        Octal,
        Hexadecimal
    }

    [ToolboxBitmap(@"C:\Users\unexi\Documents\KHAI\APPZ\Lab_1_APPZ_1\WindowsFormsControlLibrary1\HexOctDecControl.ico")]
    public partial class HexOctDecControl : UserControl
    {
        private int _number;
        private NumberFormat _format;

        public HexOctDecControl()
        {
            InitializeComponent();
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox2.ReadOnly = true;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                _number = number;
                UpdateSecondTextBox();
                OnFormatChanged(EventArgs.Empty);
            }
        }

        private void UpdateSecondTextBox()
        {
            switch (_format)
            {
                case NumberFormat.Decimal:
                    textBox2.Text = _number.ToString();
                    break;
                case NumberFormat.Octal:
                    textBox2.Text = Convert.ToString(_number, 8);
                    break;
                case NumberFormat.Hexadecimal:
                    textBox2.Text = Convert.ToString(_number, 16).ToUpper();
                    break;
            }
        }

        [Category("Behavior")]
        [Description("Format to display the number.")]
        public NumberFormat Format
        {
            get { return _format; }
            set
            {
                if (_format != value)
                {
                    _format = value;
                    UpdateSecondTextBox();
                    OnFormatChanged(EventArgs.Empty);
                }
            }
        }

        public event EventHandler FormatChanged;

        protected virtual void OnFormatChanged(EventArgs e)
        {
            FormatChanged?.Invoke(this, e);
        }
    }
}