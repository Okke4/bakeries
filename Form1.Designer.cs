namespace mainApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            addBakeryButton = new Button();
            addStallButton = new Button();
            button1 = new Button();
            updateBakeryButton = new Button();
            deleteBakeryButton = new Button();
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
            dataGridView1.Location = new Point(257, 91);
            dataGridView1.MaximumSize = new Size(4702, 3710);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(472, 371);
            dataGridView1.TabIndex = 0;
            // 
            // addBakeryButton
            // 
            addBakeryButton.BackColor = SystemColors.ControlLightLight;
            addBakeryButton.Location = new Point(53, 91);
            addBakeryButton.Name = "addBakeryButton";
            addBakeryButton.Size = new Size(154, 33);
            addBakeryButton.TabIndex = 1;
            addBakeryButton.Text = "Добавить хлебозавод";
            addBakeryButton.UseVisualStyleBackColor = false;
            addBakeryButton.Click += addBakeryButton_Click;
            // 
            // addStallButton
            // 
            addStallButton.BackColor = SystemColors.ControlLightLight;
            addStallButton.Location = new Point(53, 315);
            addStallButton.Name = "addStallButton";
            addStallButton.Size = new Size(154, 30);
            addStallButton.TabIndex = 2;
            addStallButton.Text = "Показать киоски";
            addStallButton.UseVisualStyleBackColor = false;
            addStallButton.Click += addStallButton_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(53, 432);
            button1.Name = "button1";
            button1.Size = new Size(154, 30);
            button1.TabIndex = 3;
            button1.Text = "Сформировать отчет";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // updateBakeryButton
            // 
            updateBakeryButton.BackColor = SystemColors.ControlLightLight;
            updateBakeryButton.Location = new Point(53, 144);
            updateBakeryButton.Name = "updateBakeryButton";
            updateBakeryButton.Size = new Size(154, 41);
            updateBakeryButton.TabIndex = 4;
            updateBakeryButton.Text = "Редактировать хлебозавод";
            updateBakeryButton.UseVisualStyleBackColor = false;
            updateBakeryButton.Click += updateBakeryButton_Click;
            // 
            // deleteBakeryButton
            // 
            deleteBakeryButton.BackColor = SystemColors.ControlLightLight;
            deleteBakeryButton.Location = new Point(53, 204);
            deleteBakeryButton.Name = "deleteBakeryButton";
            deleteBakeryButton.Size = new Size(154, 33);
            deleteBakeryButton.TabIndex = 5;
            deleteBakeryButton.Text = "Удалить хлебозавод";
            deleteBakeryButton.UseVisualStyleBackColor = false;
            deleteBakeryButton.Click += deleteBakeryButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 491);
            Controls.Add(deleteBakeryButton);
            Controls.Add(updateBakeryButton);
            Controls.Add(button1);
            Controls.Add(addStallButton);
            Controls.Add(addBakeryButton);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Хлебозаводы";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addBakeryButton;
        private Button addStallButton;
        private Button button1;
        private Button updateBakeryButton;
        private Button deleteBakeryButton;
    }
}