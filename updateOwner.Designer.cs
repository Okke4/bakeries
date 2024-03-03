namespace mainApp
{
    partial class updateOwner
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
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(152, 257);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(130, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Location = new Point(38, 265);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 15;
            label4.Text = "Дата рождения";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(38, 204);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Отчество владельца";
            textBox3.Size = new Size(244, 23);
            textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(38, 146);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Имя владельца";
            textBox2.Size = new Size(244, 23);
            textBox2.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(92, 299);
            button1.Name = "button1";
            button1.Size = new Size(123, 33);
            button1.TabIndex = 12;
            button1.Text = "Редактировать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 91);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Фамилия владельца";
            textBox1.Size = new Size(244, 23);
            textBox1.TabIndex = 11;
            // 
            // updateOwner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 344);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "updateOwner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактировать владельца";
            Load += updateOwner_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox1;
    }
}