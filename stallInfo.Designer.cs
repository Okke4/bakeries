namespace mainApp
{
    partial class stallInfo
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
            dataGridView1 = new DataGridView();
            addStallButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            upgradeStallInfo = new Button();
            deleteStallInfo = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(210, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(503, 349);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // addStallButton
            // 
            addStallButton.BackColor = SystemColors.ControlLightLight;
            addStallButton.Location = new Point(37, 104);
            addStallButton.Name = "addStallButton";
            addStallButton.Size = new Size(127, 38);
            addStallButton.TabIndex = 1;
            addStallButton.Text = "Добавить киоск";
            addStallButton.UseVisualStyleBackColor = false;
            addStallButton.Click += addStallButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(885, 83);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Владелец";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(770, 135);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Фамилия:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Location = new Point(770, 189);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "Имя:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Location = new Point(770, 253);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 5;
            label4.Text = "Отчество:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Location = new Point(770, 313);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 6;
            label5.Text = "Дата рождения:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLightLight;
            label6.Location = new Point(885, 135);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLightLight;
            label7.Location = new Point(885, 189);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlLightLight;
            label8.Location = new Point(885, 253);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ControlLightLight;
            label9.Location = new Point(885, 313);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 10;
            // 
            // upgradeStallInfo
            // 
            upgradeStallInfo.BackColor = SystemColors.ControlLightLight;
            upgradeStallInfo.Location = new Point(37, 166);
            upgradeStallInfo.Name = "upgradeStallInfo";
            upgradeStallInfo.Size = new Size(127, 38);
            upgradeStallInfo.TabIndex = 11;
            upgradeStallInfo.Text = "Редактировать киоск";
            upgradeStallInfo.UseVisualStyleBackColor = false;
            upgradeStallInfo.Click += upgradeStallInfo_Click;
            // 
            // deleteStallInfo
            // 
            deleteStallInfo.BackColor = SystemColors.ControlLightLight;
            deleteStallInfo.Location = new Point(37, 230);
            deleteStallInfo.Name = "deleteStallInfo";
            deleteStallInfo.Size = new Size(127, 38);
            deleteStallInfo.TabIndex = 12;
            deleteStallInfo.Text = "Удалить киоск";
            deleteStallInfo.UseVisualStyleBackColor = false;
            deleteStallInfo.Click += deleteStallInfo_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(841, 365);
            button1.Name = "button1";
            button1.Size = new Size(127, 38);
            button1.TabIndex = 13;
            button1.Text = "Редактировать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // stallInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 496);
            Controls.Add(button1);
            Controls.Add(deleteStallInfo);
            Controls.Add(upgradeStallInfo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addStallButton);
            Controls.Add(dataGridView1);
            Name = "stallInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о киосках";
            Activated += stallInfo_Activated;
            FormClosed += stallInfo_FormClosed;
            Load += stallInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addStallButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button upgradeStallInfo;
        private Button deleteStallInfo;
        private Button button1;
    }
}