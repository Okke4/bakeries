namespace mainApp
{
    partial class updateStall
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
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(137, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 23);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.Value = new DateTime(2024, 2, 22, 0, 0, 0, 0);
            // 
            // textBox4
            // 
            textBox4.Location = new Point(31, 247);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Средний доход за день";
            textBox4.Size = new Size(257, 23);
            textBox4.TabIndex = 14;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(31, 136);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Адрес киоска";
            textBox2.Size = new Size(257, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 81);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Номер киоска";
            textBox1.Size = new Size(257, 23);
            textBox1.TabIndex = 12;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Location = new Point(31, 200);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 11;
            label3.Text = "Дата открытия";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(97, 298);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 10;
            button1.Text = "Редактировать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // updateStall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 345);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Name = "updateStall";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактировать киоск";
            Load += updateStall_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
    }
}