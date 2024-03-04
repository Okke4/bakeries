using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace mainApp
{
    public partial class addStall : MaterialForm
    {
        public addStall(int bakery_id)
        {
            InitializeComponent();
            this.bakery_id = bakery_id;
        }

        int bakery_id;
        DB db = new();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "") 
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("INSERT INTO `stall` (`number`, `address`, `opened`, `income`, `bakery_id`) VALUES (@number, @address, @opened, @income, @bakery_id)", db.getConnection());
                command.Parameters.Add("@number", MySqlDbType.Text).Value = textBox1.Text;
                command.Parameters.Add("@address", MySqlDbType.Text).Value = textBox2.Text;
                command.Parameters.Add("@opened", MySqlDbType.Text).Value = dateTimePicker1.Text;
                command.Parameters.Add("@income", MySqlDbType.Text).Value = textBox4.Text;
                command.Parameters.Add("@bakery_id", MySqlDbType.Int64).Value = bakery_id;
                command.ExecuteNonQuery();
                db.closeConnection();
                Close();
            }
            else { MessageBox.Show("Заполните все поля!"); }
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
