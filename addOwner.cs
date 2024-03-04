using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace mainApp
{
    public partial class addOwner : MaterialForm
    {
        public addOwner(int stall_id)
        {
            InitializeComponent();
            this.stall_id = stall_id;
        }

        int stall_id;
        DB db = new();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("INSERT INTO `owner` (`stall_id`, `surname`, `name`, `lastname`, `birthday`) VALUES (@stall_id, @surname, @name, @lastname, @birthday)", db.getConnection());
                command.Parameters.Add("@surname", MySqlDbType.Text).Value = textBox1.Text;
                command.Parameters.Add("@name", MySqlDbType.Text).Value = textBox2.Text;
                command.Parameters.Add("@lastname", MySqlDbType.Text).Value = textBox3.Text;
                command.Parameters.Add("@birthday", MySqlDbType.Text).Value = dateTimePicker1.Text;
                command.Parameters.Add("@stall_id", MySqlDbType.Int64).Value = stall_id;
                command.ExecuteNonQuery();
                db.closeConnection();
                Close();
            }
            else { MessageBox.Show("Заполните все поля!"); }
        }
    }
}
