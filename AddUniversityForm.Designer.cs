namespace ApplicantDirectory
{
    partial class AddUniversityForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();

            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Найменування";

            label2.AutoSize = true;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Адреса";

            label3.AutoSize = true;
            label3.Location = new Point(12, 143);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Місто";

            textBox1.Location = new Point(123, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 23);
            textBox1.TabIndex = 3;

            textBox2.Location = new Point(123, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 23);
            textBox2.TabIndex = 4;

            textBox3.Location = new Point(123, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 23);
            textBox3.TabIndex = 5;

            button1.Location = new Point(36, 199);
            button1.Name = "button1";
            button1.Size = new Size(103, 49);
            button1.TabIndex = 6;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            button2.Location = new Point(191, 199);
            button2.Name = "button2";
            button2.Size = new Size(103, 49);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 297);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddUniversityForm";
            Text = "Додавання ВНЗ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
    }
}