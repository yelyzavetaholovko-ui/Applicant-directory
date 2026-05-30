using System;
using System.Windows.Forms;

namespace ApplicantDirectory
{
    public partial class UpdateFeeForm : Form
    {
        // Властивість доступу до оновленого знач вартості
        public decimal NewCost { get; private set; }

        public UpdateFeeForm()
        {
            InitializeComponent();
        }

        // Обробка підтвердження вводу
        private void button1_Click(object sender, EventArgs e)
        {
            // Валідація введених даних : числовий формат та невід'ємність
            if (decimal.TryParse(textBox1.Text.Trim(), out decimal cost) && cost >= 0)
            {
                NewCost = cost;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка! Будь ласка, введіть коректне додатне число.");
            }
        }

        // Обробка скасування операції
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
