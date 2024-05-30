using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Додавання форматів у ComboBox
            comboBoxFormat.Items.AddRange(new object[]
            {
            NumberFormat.Decimal,
            NumberFormat.Octal,
            NumberFormat.Hexadecimal
            });

            // Встановлення початкового вибору у ComboBox
            comboBoxFormat.SelectedIndex = 0;

            // Прив'язка обробників подій
            hexOctDecControl1.FormatChanged += HexOctDecControl1_FormatChanged;
            buttonUpdateFormat.Click += ButtonUpdateFormat_Click;
        }

        private void HexOctDecControl1_FormatChanged(object sender, EventArgs e)
        {
            // Оновлення відображення поточного формату
            labelCurrentFormat.Text = $"Current Format: {hexOctDecControl1.Format}";
        }

        private void ButtonUpdateFormat_Click(object sender, EventArgs e)
        {
            // Зміна формату компонента на основі вибору користувача
            hexOctDecControl1.Format = (NumberFormat)comboBoxFormat.SelectedItem;
        }
    }
}
