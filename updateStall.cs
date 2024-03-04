using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace mainApp
{
    public partial class updateStall : MaterialForm
    {
        public updateStall(int stall_id)
        {
            InitializeComponent();
            this.stall_id = stall_id;
        }

        int stall_id;
        DB db = new DB();

        private void updateStall_Load(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT `number` FROM `stall` WHERE id = '" + stall_id + "'", db.getConnection());
            textBox1.Text = command.ExecuteScalar().ToString();
            MySqlCommand command2 = new MySqlCommand("SELECT `address` FROM `stall` WHERE id = '" + stall_id + "'", db.getConnection());
            textBox2.Text = command2.ExecuteScalar().ToString();
            MySqlCommand command3 = new MySqlCommand("SELECT `opened` FROM `stall` WHERE id = '" + stall_id + "'", db.getConnection());
            dateTimePicker1.Text = command3.ExecuteScalar().ToString();
            MySqlCommand command4 = new MySqlCommand("SELECT `income` FROM `stall` WHERE id = '" + stall_id + "'", db.getConnection());
            textBox4.Text = command4.ExecuteScalar().ToString();
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "")
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("UPDATE `stall` SET `number` = @number, `address` = @address, `opened` = @opened, `income` = @income WHERE `id` = @stall_id;", db.getConnection());
                command.Parameters.Add("@number", MySqlDbType.Text).Value = textBox1.Text;
                command.Parameters.Add("@address", MySqlDbType.Text).Value = textBox2.Text;
                command.Parameters.Add("@opened", MySqlDbType.Text).Value = dateTimePicker1.Text;
                command.Parameters.Add("@income", MySqlDbType.Text).Value = textBox4.Text;
                command.Parameters.Add("@stall_id", MySqlDbType.Int64).Value = stall_id;
                command.ExecuteNonQuery();
                db.closeConnection();
                Close();
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
