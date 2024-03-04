using iTextSharp.text;
using iTextSharp.text.pdf;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using System.Diagnostics;
using Font = iTextSharp.text.Font;

namespace mainApp
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        DB db = new();

        private void Form1_Load(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void addBakeryButton_Click(object sender, EventArgs e)
        {
            addBakery addBakery = new();
            addBakery.Show();
        }

        private void addStallButton_Click(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlDataAdapter adapter = new("SELECT * FROM bakery", db.getConnection());
            DataTable dt = new();
            adapter.Fill(dt);
            int[] array = new int[dt.Rows.Count];
            var rows = dt.AsEnumerable();
            array = rows.Select(row => row.Field<int>(0)).ToArray();
            string toDisplay = string.Join(Environment.NewLine, array);
            int bakery_id = array[dataGridView1.CurrentRow.Index];
            db.closeConnection();
            stallInfo stallInfo = new(bakery_id);
            stallInfo.Show();
            this.Hide();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                db.openConnection();
                MySqlDataAdapter adapter = new("SELECT * FROM bakery", db.getConnection());
                DataTable dt = new();
                adapter.Fill(dt);
                int[] array = new int[dt.Rows.Count];
                var rows = dt.AsEnumerable();
                array = rows.Select(row => row.Field<int>(0)).ToArray();
                string toDisplay = string.Join(Environment.NewLine, array);
                int bakery_id = array[dataGridView1.CurrentRow.Index];
                db.closeConnection();

                string query = ("SELECT `stall`.`number`, `stall`.`address`, `stall`.`opened`, `stall`.`income`, `owner`.`surname`, `owner`.`name`, `owner`.`lastname`, `owner`.`birthday` FROM `stall` LEFT JOIN `owner` ON `owner`.`stall_id` = `stall`.`id` WHERE `bakery_id` = " + bakery_id);

                //Variables to create PDF document
                Document doc = new();
                PdfWriter.GetInstance(doc, new FileStream(@"MySQL_to_PDF_table.pdf", FileMode.Create)); //Output PDF file
                PdfPTable table = new(8); //To create table inside the PDF

                //Width of each column on table
                float[] widths = { 70f, 110f, 110f, 110f, 110f, 110f, 110f, 110f };
                table.SetWidthPercentage(widths, PageSize.A3);

                //Font settings
                Font titleFont = FontFactory.GetFont("C:\\Windows\\Fonts\\arial.ttf", "Identity-H");
                titleFont.SetStyle("bold");
                Font textFont = FontFactory.GetFont("C:\\Windows\\Fonts\\arial.ttf", "Identity-H");
                titleFont.SetStyle("normal");


                db.openConnection(); //Access database

                //Prepare SQL query to retrive data
                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
                MySqlDataReader dataReader = cmd.ExecuteReader();
                

                doc.Open(); //Access the PDF Document to write data

                //Add table column headers
                table.AddCell(new Paragraph("Номер", titleFont));
                table.AddCell(new Paragraph("Адрес", titleFont));
                table.AddCell(new Paragraph("Дата открытия", titleFont));
                table.AddCell(new Paragraph("Ежедневный доход", titleFont));
                table.AddCell(new Paragraph("Фамилия", titleFont));
                table.AddCell(new Paragraph("Имя", titleFont));
                table.AddCell(new Paragraph("Отчество", titleFont));
                table.AddCell(new Paragraph("Дата рождения", titleFont));

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    //Add data to table
                    table.AddCell(new Paragraph(dataReader["number"].ToString(), textFont));
                    table.AddCell(new Paragraph(dataReader["address"].ToString(), textFont));
                    table.AddCell(new Paragraph(dataReader["opened"].ToString(), textFont));
                    table.AddCell(new Paragraph(dataReader["income"].ToString(), textFont));
                    table.AddCell(new Paragraph(dataReader["surname"].ToString(), textFont));
                    table.AddCell(new Paragraph(dataReader["name"].ToString(), textFont));
                    table.AddCell(new Paragraph(dataReader["lastname"].ToString(), textFont));
                    table.AddCell(new Paragraph(dataReader["birthday"].ToString(), textFont));
                }

                //Close the DataReader
                dataReader.Close();

                //Close database connection
                db.closeConnection();
                db.openConnection();
                MySqlCommand command = new MySqlCommand("select * from bakery WHERE id = "+bakery_id, db.getConnection());
                MySqlDataReader mydataReader = command.ExecuteReader();
                mydataReader.Read();
                string? bakery_number = mydataReader.GetValue(1).ToString();
                mydataReader.Close();
                db.closeConnection();
                //Add data to PDF file
                doc.Add(new Paragraph("Список киосков, относящихся к " + bakery_number + " хлебозаводу.\n\n", textFont));
                doc.Add(table);
                db.openConnection();
                MySqlCommand avgcmd = new("SELECT AVG (income) FROM stall WHERE bakery_id = " + bakery_id, db.getConnection());
                int avg = Convert.ToInt32(avgcmd.ExecuteScalar());
                db.closeConnection();
                avg = avg * 7;
                doc.Add(new Paragraph("\n\nСредний еженедельный доход составляет " + avg + " руб.", textFont));

                //Close PDF document
                doc.Close();

                //Open the Output file
                Process.Start(new ProcessStartInfo(@"MySQL_to_PDF_table.pdf") { UseShellExecute = true });
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        public void updateGrid()
        {
            try
            {
                db.openConnection();
                MySqlDataAdapter adapter = new("SELECT `number` AS Номер, `phone` AS Телефон, `address` AS Адрес FROM `bakery`;", db.getConnection());
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

        private void updateBakeryButton_Click(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlDataAdapter adapter = new("SELECT * FROM bakery", db.getConnection());
            DataTable dt = new();
            adapter.Fill(dt);
            int[] array = new int[dt.Rows.Count];
            var rows = dt.AsEnumerable();
            array = rows.Select(row => row.Field<int>(0)).ToArray();
            string toDisplay = string.Join(Environment.NewLine, array);
            int bakery_id = array[dataGridView1.CurrentRow.Index];
            db.closeConnection();
            updateBakery updateBakery = new(bakery_id);
            updateBakery.Show();
        }

        private void deleteBakeryButton_Click(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                MySqlDataAdapter adapterId = new("SELECT * FROM bakery", db.getConnection());
                DataTable dtId = new();
                adapterId.Fill(dtId);
                int[] array = new int[dtId.Rows.Count];
                var rows = dtId.AsEnumerable();
                array = rows.Select(row => row.Field<int>(0)).ToArray();
                string toDisplay = string.Join(Environment.NewLine, array);
                int bakery_id = array[dataGridView1.CurrentRow.Index];
                db.closeConnection();
                db.openConnection();
                MySqlDataAdapter adapter = new("DELETE FROM bakery WHERE id = " + bakery_id, db.getConnection());
                DataTable dt = new();
                adapter.Fill(dt);
                db.closeConnection();
                updateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}