using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mainApp
{
    public partial class updateOwner : MaterialForm
    {
        public updateOwner(int stall_id)
        {
            InitializeComponent();
            this.stall_id = stall_id;
        }

        int stall_id;
        DB db = new DB();

        private void updateOwner_Load(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT `surname` FROM `owner` WHERE stall_id = '" + stall_id + "'", db.getConnection());
            textBox1.Text = command.ExecuteScalar().ToString();
            MySqlCommand command2 = new MySqlCommand("SELECT `name` FROM `owner` WHERE stall_id = '" + stall_id + "'", db.getConnection());
            textBox2.Text = command2.ExecuteScalar().ToString();
            MySqlCommand command4 = new MySqlCommand("SELECT `lastname` FROM `owner` WHERE stall_id = '" + stall_id + "'", db.getConnection());
            textBox3.Text = command4.ExecuteScalar().ToString();
            MySqlCommand command3 = new MySqlCommand("SELECT `birthday` FROM `owner` WHERE stall_id = '" + stall_id + "'", db.getConnection());
            dateTimePicker1.Text = command3.ExecuteScalar().ToString();
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("UPDATE `owner` SET `surname` = @surname, `name` = @name, `lastname` = @lastname, `birthday` = @birthday WHERE `stall_id` = @stall_id;", db.getConnection());
                command.Parameters.Add("@surname", MySqlDbType.Text).Value = textBox1.Text;
                command.Parameters.Add("@name", MySqlDbType.Text).Value = textBox2.Text;
                command.Parameters.Add("@lastname", MySqlDbType.Text).Value = textBox3.Text;
                command.Parameters.Add("@birthday", MySqlDbType.Text).Value = dateTimePicker1.Text;
                command.Parameters.Add("@stall_id", MySqlDbType.Int64).Value = stall_id;
                command.ExecuteNonQuery();
                db.closeConnection();
                Close();
            }
            else MessageBox.Show("Заполните все поля!");
        }
    }
}
