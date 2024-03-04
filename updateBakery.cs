using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace mainApp
{
    public partial class updateBakery : MaterialForm
    {
        public updateBakery(int bakery_id)
        {
            InitializeComponent();
            this.bakery_id = bakery_id;
        }

        int bakery_id;
        DB db = new DB();

        private void updateBakery_Load(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT `number` FROM `bakery` WHERE id = '" + bakery_id + "'", db.getConnection());
            textBox1.Text = command.ExecuteScalar().ToString();
            MySqlCommand command2 = new MySqlCommand("SELECT `phone` FROM `bakery` WHERE id = '" + bakery_id + "'", db.getConnection());
            textBox2.Text = command2.ExecuteScalar().ToString();
            MySqlCommand command3 = new MySqlCommand("SELECT `address` FROM `bakery` WHERE id = '" + bakery_id + "'", db.getConnection());
            textBox3.Text = command3.ExecuteScalar().ToString();
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                MySqlCommand command = new MySqlCommand("UPDATE `bakery` SET `number` = @number, `phone` = @phone, `address` = @address WHERE `id` = @id;", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = bakery_id;
                command.Parameters.Add("@number", MySqlDbType.Text).Value = textBox1.Text;
                command.Parameters.Add("@phone", MySqlDbType.Text).Value = textBox2.Text;
                command.Parameters.Add("@address", MySqlDbType.Text).Value = textBox3.Text;
                db.openConnection();
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
    }
}
