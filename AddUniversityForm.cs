using System;
using System.Windows.Forms;

namespace ApplicantDirectory
{
    public partial class AddUniversityForm : Form
    {
        // Об'єкт нового ЗВО для передачі в головну форму
        public University NewUniversity { get; private set; }

        public AddUniversityForm()
        {
            InitializeComponent();
        }

        // Ініціалізація полів форми при редагуванні існуючого запису
        public void SetupForEdit(string name, string address, string city)
        {
            textBox1.Text = name;
            textBox2.Text = address;
            textBox3.Text = city;
        }

        // Обробка збереження даних
        private void button1_Click(object sender, EventArgs e)
        {
            // Перевірка наявності необхідних текстових даних
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля!");
                return;
            }

            // Ініціалізація нового об'єкта класу University
            NewUniversity = new University(textBox1.Text, textBox2.Text, textBox3.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Обробка скасування
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}