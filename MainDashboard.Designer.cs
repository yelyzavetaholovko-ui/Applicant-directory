namespace ApplicantDirectory
{
    partial class MainDashboard
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            labelCount = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1463, 723);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labelCount);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1455, 695);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Пошук";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(474, 209);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(137, 15);
            labelCount.TabIndex = 26;
            labelCount.Text = "Знайдено результатів: 0";
            labelCount.Click += labelCount_Click;
            // 
            // button4
            // 
            button4.Location = new Point(474, 498);
            button4.Name = "button4";
            button4.Size = new Size(132, 47);
            button4.TabIndex = 25;
            button4.Text = "Оновити вартість";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(174, 498);
            button3.Name = "button3";
            button3.Size = new Size(132, 47);
            button3.TabIndex = 24;
            button3.Text = "Видалити";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(256, 584);
            button2.Name = "button2";
            button2.Size = new Size(272, 52);
            button2.TabIndex = 23;
            button2.Text = "Додати ВНЗ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(174, 188);
            button1.Name = "button1";
            button1.Size = new Size(225, 56);
            button1.TabIndex = 22;
            button1.Text = "Знайти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(35, 264);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(732, 214);
            listBox1.TabIndex = 21;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(174, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(437, 23);
            textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(174, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(437, 23);
            textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(437, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(437, 23);
            textBox1.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 139);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 16;
            label4.Text = "Місто";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 102);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 15;
            label3.Text = "Макс. вартість";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 62);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 14;
            label2.Text = "Форма навчання";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 27);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 13;
            label1.Text = "Назва спеціальності";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1455, 695);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Довідник ВНЗ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(502, 631);
            button8.Name = "button8";
            button8.Size = new Size(127, 46);
            button8.TabIndex = 5;
            button8.Text = "Очистити";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(348, 630);
            button7.Name = "button7";
            button7.Size = new Size(127, 47);
            button7.TabIndex = 4;
            button7.Text = "Видалити";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(191, 631);
            button6.Name = "button6";
            button6.Size = new Size(127, 47);
            button6.TabIndex = 3;
            button6.Text = "Редагувати";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(32, 631);
            button5.Name = "button5";
            button5.Size = new Size(127, 46);
            button5.TabIndex = 2;
            button5.Text = "Додати ВНЗ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(842, 46);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(579, 555);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(597, 555);
            dataGridView1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 747);
            Controls.Add(tabControl1);
            Name = "MainDashboard";
            Text = "MainDashboard";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ListBox listBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Label labelCount;
    }
}