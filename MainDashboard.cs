using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ApplicantDirectory
{
    public partial class MainDashboard : Form
    {
        AppManager manager = new AppManager();

        public MainDashboard()
        {
            InitializeComponent();

            // Завантаження існуючої бази даних при запуску програми
            try
            {
                manager.LoadFromFile();
            }
            catch
            {
                manager.Universities.Clear();
            }

            // Створення бази даних у разі відсутності файлу
            if (manager.Universities.Count < 10)
            {
                manager.Universities.Clear();

                University knu = new University("КНУ ім. Шевченка", "вул. Володимирська 60", "Київ");
                knu.AddSpecialty(new Specialty("Інженерія програмного забезпечення", 175.0, 165.0, 160.0, 45000));
                knu.AddSpecialty(new Specialty("Право", 180.0, 0, 170.0, 50000));
                knu.AddSpecialty(new Specialty("Журналістика", 172.0, 0, 165.0, 48000));

                University kpi = new University("КПІ ім. Сікорського", "пр. Берестейський 37", "Київ");
                kpi.AddSpecialty(new Specialty("Кібербезпека", 170.0, 160.0, 0, 42000));
                kpi.AddSpecialty(new Specialty("Комп'ютерні науки", 168.0, 0, 150.0, 40000));
                kpi.AddSpecialty(new Specialty("Біомедична інженерія", 160.0, 0, 0, 35000));

                University naukma = new University("НаУКМА", "вул. Сковороди 2", "Київ");
                naukma.AddSpecialty(new Specialty("Маркетинг", 178.0, 168.0, 0, 47000));
                naukma.AddSpecialty(new Specialty("Економіка", 175.0, 0, 0, 46000));

                University nure = new University("ХНУРЕ", "пр. Науки 14", "Харків");
                nure.AddSpecialty(new Specialty("Інженерія програмного забезпечення", 160.5, 0, 140.0, 30000));
                nure.AddSpecialty(new Specialty("Кібербезпека", 165.0, 158.0, 145.0, 32000));
                nure.AddSpecialty(new Specialty("Системний аналіз", 158.0, 0, 0, 28000));

                University khpi = new University("НТУ ХПІ", "вул. Кирпичова 2", "Харків");
                khpi.AddSpecialty(new Specialty("Інженерія програмного забезпечення", 158.0, 0, 138.0, 28000));
                khpi.AddSpecialty(new Specialty("Менеджмент", 150.0, 145.0, 140.0, 25000));

                University karazin = new University("ХНУ ім. Каразіна", "майдан Свободи 4", "Харків");
                karazin.AddSpecialty(new Specialty("Філологія", 165.0, 155.0, 150.0, 33000));
                karazin.AddSpecialty(new Specialty("Міжнародні відносини", 170.0, 0, 0, 38000));

                University lvivPoly = new University("Львівська політехніка", "вул. С. Бандери 12", "Львів");
                lvivPoly.AddSpecialty(new Specialty("Інженерія програмного забезпечення", 165.0, 155.0, 150.0, 35000));
                lvivPoly.AddSpecialty(new Specialty("Архітектура", 160.0, 0, 0, 38000));
                lvivPoly.AddSpecialty(new Specialty("Дизайн", 158.0, 0, 0, 36000));

                University lnu = new University("ЛНУ ім. Франка", "вул. Університетська 1", "Львів");
                lnu.AddSpecialty(new Specialty("Психологія", 168.0, 160.0, 155.0, 32000));
                lnu.AddSpecialty(new Specialty("Право", 175.0, 0, 160.0, 40000));

                University mechnikov = new University("ОНУ ім. Мечникова", "вул. Дворянська 2", "Одеса");
                mechnikov.AddSpecialty(new Specialty("Філологія", 155.0, 0, 145.0, 28000));
                mechnikov.AddSpecialty(new Specialty("Психологія", 160.0, 150.0, 150.0, 30000));

                University odessaPoly = new University("Одеська політехніка", "пр. Шевченка 1", "Одеса");
                odessaPoly.AddSpecialty(new Specialty("Комп'ютерні науки", 158.0, 0, 145.0, 29000));
                odessaPoly.AddSpecialty(new Specialty("Електроенергетика", 150.0, 145.0, 135.0, 25000));

                University dnu = new University("ДНУ ім. Гончара", "пр. Гагаріна 72", "Дніпро");
                dnu.AddSpecialty(new Specialty("Журналістика", 160.0, 0, 150.0, 27000));
                dnu.AddSpecialty(new Specialty("Економіка", 158.0, 150.0, 148.0, 26000));

                University dniproPoly = new University("Дніпровська політехніка", "пр. Яворницького 19", "Дніпро");
                dniproPoly.AddSpecialty(new Specialty("Кібербезпека", 162.0, 0, 152.0, 28000));
                dniproPoly.AddSpecialty(new Specialty("Гірництво", 145.0, 0, 135.0, 20000));

                University vntu = new University("ВНТУ", "Хмельницьке шосе 95", "Вінниця");
                vntu.AddSpecialty(new Specialty("Комп'ютерні науки", 155.0, 150.0, 140.0, 26000));
                vntu.AddSpecialty(new Specialty("Інженерія програмного забезпечення", 158.0, 0, 145.0, 27500));

                manager.Universities.Add(knu); manager.Universities.Add(kpi); manager.Universities.Add(naukma);
                manager.Universities.Add(nure); manager.Universities.Add(khpi); manager.Universities.Add(karazin);
                manager.Universities.Add(lvivPoly); manager.Universities.Add(lnu); manager.Universities.Add(mechnikov);
                manager.Universities.Add(odessaPoly); manager.Universities.Add(dnu); manager.Universities.Add(dniproPoly);
                manager.Universities.Add(vntu);

                manager.SaveToFile();
            }

            SetupTables();
            UpdateUniversityTable();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        //Встановлення колонок для таблиць 
        private void SetupTables()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Назва ВНЗ";
            dataGridView1.Columns[1].Name = "Місто";
            dataGridView1.Columns[2].Name = "Адреса";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            dataGridView2.ColumnCount = 5;
            dataGridView2.Columns[0].Name = "Спеціальність";
            dataGridView2.Columns[1].Name = "Денна (бал)";
            dataGridView2.Columns[2].Name = "Вечірня (бал)";
            dataGridView2.Columns[3].Name = "Заочна (бал)";
            dataGridView2.Columns[4].Name = "Вартість (грн)";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ReadOnly = true;
        }

        private void UpdateUniversityTable()
        {
            dataGridView1.Rows.Clear();

            foreach (var uni in manager.Universities)
            {
                dataGridView1.Rows.Add(uni.Name, uni.City, uni.Address);
            }
        }

        // Обробка при виборі ЗВО - оновлюється список спеціальностей справа в табл
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                University selectedUni = manager.Universities[selectedIndex];

                foreach (var spec in selectedUni.Specialties)
                {
                    string dayScore = spec.FullTimeScore > 0 ? spec.FullTimeScore.ToString() : "-";
                    string eveScore = spec.EveningScore > 0 ? spec.EveningScore.ToString() : "-";
                    string distScore = spec.ExtramuralScore > 0 ? spec.ExtramuralScore.ToString() : "-";

                    dataGridView2.Rows.Add(spec.Title, dayScore, eveScore, distScore, spec.TuitionFee);
                }
            }
        }

        //Пошук та фільтрація даних
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string searchTitle = textBox1.Text.ToLower();
            string searchForm = textBox2.Text.ToLower();
            string searchCity = textBox4.Text.ToLower();

            decimal maxCost = decimal.MaxValue;
            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                decimal.TryParse(textBox3.Text, out maxCost);
            }

            var results = new List<(double MinScore, string Text)>();

            foreach (var uni in manager.Universities)
            {
                if (!string.IsNullOrWhiteSpace(searchCity) && !uni.City.ToLower().Contains(searchCity)) continue;

                foreach (var spec in uni.Specialties)
                {
                    if (!string.IsNullOrWhiteSpace(searchTitle) && !spec.Title.ToLower().Contains(searchTitle)) continue;
                    if (spec.TuitionFee > maxCost) continue;

                    if (searchForm.Contains("денн") && spec.FullTimeScore <= 0) continue;
                    if (searchForm.Contains("вечірн") && spec.EveningScore <= 0) continue;
                    if (searchForm.Contains("заоч") && spec.ExtramuralScore <= 0) continue;

                    string availableForms = "";
                    double minScore = double.MaxValue;

                    if (spec.FullTimeScore > 0) { availableForms += "[Денна] "; if (spec.FullTimeScore < minScore) minScore = spec.FullTimeScore; }
                    if (spec.EveningScore > 0) { availableForms += "[Вечірня] "; if (spec.EveningScore < minScore) minScore = spec.EveningScore; }
                    if (spec.ExtramuralScore > 0) { availableForms += "[Заочна]"; if (spec.ExtramuralScore < minScore) minScore = spec.ExtramuralScore; }

                    if (minScore == double.MaxValue) minScore = 0;

                    string displayText = $"{uni.Name} ({uni.City}) — {spec.Title} | {availableForms} | {spec.TuitionFee} грн | Мін. бал: {minScore}";
                    results.Add((minScore, displayText));
                }
            }

            // Сортування результатів за зростанням мін прохід бала
            var sortedResults = results.OrderBy(r => r.MinScore).ToList();

            foreach (var item in sortedResults)
            {
                listBox1.Items.Add(item.Text);
            }

            if (sortedResults.Count == 0)
            {
                listBox1.Items.Add("На жаль, за вашим запитом нічого не знайдено.");
                labelCount.Text = "Знайдено результатів: 0";
            }
            else
            {
                labelCount.Text = $"Знайдено результатів: {sortedResults.Count}";
            }
        }

        private void labelCount_Click(object sender, EventArgs e)
        {

        }

        //Видалення обраного навчального закладу з бази даних
        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Ви дійсно хочете назавжди видалити цей університет з бази?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    manager.Universities.RemoveAt(selectedIndex);
                    manager.SaveToFile();
                    UpdateUniversityTable();
                    dataGridView2.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, спочатку виберіть університет зі списку!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Очищення колекції даних, перезапис даних
        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Ви впевнені, що хочете ПОВНІСТЮ ВИДАЛИТИ ВСІ університети з бази?",
                "Небезпечна операція!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop);

            if (result == DialogResult.Yes)
            {
                manager.Universities.Clear();
                manager.SaveToFile();
                UpdateUniversityTable();
                dataGridView2.Rows.Clear();
            }
        }

        // Виклик  вікна - додавання нового ЗВО
        private void button5_Click(object sender, EventArgs e)
        {
            AddUniversityForm addUniWindow = new AddUniversityForm();
            if (addUniWindow.ShowDialog() == DialogResult.OK)
            {
                manager.Universities.Add(addUniWindow.NewUniversity);
                manager.SaveToFile();
                UpdateUniversityTable();
                MessageBox.Show("Університет успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Оновлення вартості навчання
        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                UpdateFeeForm updateCostWindow = new UpdateFeeForm();

                if (updateCostWindow.ShowDialog() == DialogResult.OK)
                {
                    string selectedText = listBox1.SelectedItem.ToString();

                    foreach (var uni in manager.Universities)
                    {
                        foreach (var spec in uni.Specialties)
                        {
                            if (selectedText.Contains(uni.Name) && selectedText.Contains(spec.Title))
                            {
                                spec.TuitionFee = updateCostWindow.NewCost;
                                manager.SaveToFile();
                                button1.PerformClick();
                                MessageBox.Show("Вартість успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, спочатку виберіть спеціальність зі списку!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddUniversityForm addUniWindow = new AddUniversityForm();
            if (addUniWindow.ShowDialog() == DialogResult.OK)
            {
                manager.Universities.Add(addUniWindow.NewUniversity);
                manager.SaveToFile();
                UpdateUniversityTable();
                MessageBox.Show("Університет успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Приховування обраного запису з результатів пошуку
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show(
                    "Ви дійсно хочете видалити цей запис?",
                    "Підтвердження",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    labelCount.Text = $"Знайдено результатів: {listBox1.Items.Count}";
                }
            }
            else
            {
                MessageBox.Show("Виберіть запис для видалення!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Виклик вікна, щоб редагувати ЗВО
        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                University selectedUni = manager.Universities[selectedIndex];

                AddUniversityForm editWindow = new AddUniversityForm();
                editWindow.Text = "Редагування ВНЗ";
                editWindow.SetupForEdit(selectedUni.Name, selectedUni.Address, selectedUni.City);

                if (editWindow.ShowDialog() == DialogResult.OK)
                {
                    selectedUni.Name = editWindow.NewUniversity.Name;
                    selectedUni.Address = editWindow.NewUniversity.Address;
                    selectedUni.City = editWindow.NewUniversity.City;

                    manager.SaveToFile();
                    UpdateUniversityTable();

                    MessageBox.Show("Дані університету успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, спочатку виберіть університет для редагування!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
