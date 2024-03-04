using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace mainApp
{
    public partial class addBakery : MaterialForm
    {
        public addBakery()
        {
            InitializeComponent();
        }

        DB db = new();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "") 
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("INSERT INTO `bakery` (`number`, `phone`, `address`) VALUES (@number, @phone, @address)", db.getConnection());
                command.Parameters.Add("@number", MySqlDbType.Text).Value = textBox1.Text;
                command.Parameters.Add("@phone", MySqlDbType.Text).Value = textBox2.Text;
                command.Parameters.Add("@address", MySqlDbType.Text).Value = textBox3.Text;
                command.ExecuteNonQuery();
                db.closeConnection();
                Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
