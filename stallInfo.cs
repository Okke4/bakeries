using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System.Data;

namespace mainApp
{
    public partial class stallInfo : MaterialForm
    {
        public stallInfo(int bakery_id)
        {
            InitializeComponent();
            this.bakery_id = bakery_id;
        }

        int bakery_id;
        DB db = new();

        private void stallInfo_Load(object sender, EventArgs e)
        {
            upgradeGrid();
            ownerInfo();
        }

        private void addStallButton_Click(object sender, EventArgs e)
        {
            addStall addStall = new(bakery_id);
            addStall.Show();
        }

        private void stallInfo_Activated(object sender, EventArgs e)
        {
            upgradeGrid();
            ownerInfo();
            upgradeGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ownerInfo();
        }

        private void upgradeStallInfo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                db.openConnection();
                MySqlDataAdapter adapterId = new("SELECT * FROM stall WHERE bakery_id = " + bakery_id, db.getConnection());
                DataTable dtId = new();
                adapterId.Fill(dtId);
                int[] array = new int[dtId.Rows.Count];
                var rows = dtId.AsEnumerable();
                array = rows.Select(row => row.Field<int>(0)).ToArray();
                string toDisplay = string.Join(Environment.NewLine, array);
                int stall_id = array[dataGridView1.CurrentRow.Index];
                db.closeConnection();
                updateStall updateStall = new updateStall(stall_id);
                updateStall.Show();
            }
        }

        private void deleteStallInfo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    db.openConnection();
                    MySqlDataAdapter adapterId = new("SELECT * FROM stall WHERE bakery_id = " + bakery_id, db.getConnection());
                    DataTable dtId = new();
                    adapterId.Fill(dtId);
                    int[] array = new int[dtId.Rows.Count];
                    var rows = dtId.AsEnumerable();
                    array = rows.Select(row => row.Field<int>(0)).ToArray();
                    string toDisplay = string.Join(Environment.NewLine, array);
                    int stall_id = array[dataGridView1.CurrentRow.Index];
                    MySqlDataAdapter adapter = new("DELETE FROM stall WHERE id = " + stall_id, db.getConnection());
                    DataTable dt = new();
                    adapter.Fill(dt);
                    db.closeConnection();
                    upgradeGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void upgradeGrid()
        {
            try
            {
                db.openConnection();
                MySqlDataAdapter adapter = new("SELECT `number` AS Номер, `address` AS Адрес, `opened` AS `Дата открытия`, `income` AS Доход FROM `stall` WHERE bakery_id =" + bakery_id, db.getConnection());
                DataTable dt = new();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ownerInfo()
        {
            db.openConnection();
            if (dataGridView1.Rows.Count > 0)
            {
                MySqlDataAdapter adapterId = new("SELECT * FROM stall WHERE bakery_id = " + bakery_id, db.getConnection());
                DataTable dtId = new();
                adapterId.Fill(dtId);
                int[] array = new int[dtId.Rows.Count];
                var rows = dtId.AsEnumerable();
                array = rows.Select(row => row.Field<int>(0)).ToArray();
                string toDisplay = string.Join(Environment.NewLine, array);
                int stall_id = array[dataGridView1.CurrentRow.Index];
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command5 = new MySqlCommand("SELECT * FROM `owner` WHERE `stall_id` = @stall_id", db.getConnection());
                command5.Parameters.Add("@stall_id", MySqlDbType.VarChar).Value = stall_id;
                adapter.SelectCommand = command5;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MySqlCommand command = new MySqlCommand("SELECT `surname` FROM `owner` WHERE stall_id = '" + stall_id + "'", db.getConnection());
                    label6.Text = command.ExecuteScalar().ToString();
                    MySqlCommand command2 = new MySqlCommand("SELECT `name` FROM `owner` WHERE stall_id = '" + stall_id + "'", db.getConnection());
                    label7.Text = command2.ExecuteScalar().ToString();
                    MySqlCommand command3 = new MySqlCommand("SELECT `lastname` FROM `owner` WHERE stall_id = '" + stall_id + "'", db.getConnection());
                    label8.Text = command3.ExecuteScalar().ToString();
                    MySqlCommand command4 = new MySqlCommand("SELECT `birthday` FROM `owner` WHERE stall_id = '" + stall_id + "'", db.getConnection());
                    label9.Text = command4.ExecuteScalar().ToString();
                }
                else
                {
                    MessageBox.Show("Добавьте владельца");
                    addOwner addOwner = new(stall_id);
                    addOwner.Show();
                }
            }
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                db.openConnection();
                MySqlDataAdapter adapterId = new("SELECT * FROM stall WHERE bakery_id = " + bakery_id, db.getConnection());
                DataTable dtId = new();
                adapterId.Fill(dtId);
                int[] array = new int[dtId.Rows.Count];
                var rows = dtId.AsEnumerable();
                array = rows.Select(row => row.Field<int>(0)).ToArray();
                string toDisplay = string.Join(Environment.NewLine, array);
                int stall_id = array[dataGridView1.CurrentRow.Index];
                db.closeConnection();
                updateOwner updateOwner = new updateOwner(stall_id);
                updateOwner.Show();
            }
        }

        private void stallInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new();
            form1.Show();
        }
    }
}
