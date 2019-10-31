using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace FOOTBALL1
{
    public partial class FormCountry : Form
    {
            public Form1 f3;
            public FormCountry(Form1 _f3)
            {
                InitializeComponent();
                f3 = _f3;
                getComboboxData2();
            }

        private void textBox1Country_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1Peoples_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3Abbr_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2Capital_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1Partoftheworld_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1SAVE_Click(object sender, EventArgs e)
        {
            string ty = textBox1Country.Text;
            string pl = textBox1Peoples.Text;
            string ab = textBox3Abbr.Text;
            string cp = textBox2Capital.Text;
            int wp = 1;
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = string.Format(@"insert into dbo.COUNTRIES (NAME_COUNTRY, POPULATION_COUNTRY,
            ABBR_COUNTRY, CAPITAL_COUNTRY, ID_PART_OF_THE_WORLD) values ('{0}', '{1}', '{2}', '{3}', {4})", ty, pl, ab, cp, wp);
            command.Connection = f3.sqlCon;
            f3.sqlCon.Open();
            int c = command.ExecuteNonQuery();
            f3.sqlCon.Close();
            MessageBox.Show("Сохранение завершено");
        }



        private void Pokazat_Click(object sender, EventArgs e)
        {
            string sqlDB;
            sqlDB = @"SELECT    dbo.COUNTRIES.ID_COUNTRY,
                                dbo.COUNTRIES.NAME_COUNTRY,
                                dbo.COUNTRIES.POPULATION_COUNTRY,
                                dbo.COUNTRIES.ABBR_COUNTRY,
                                dbo.COUNTRIES.CAPITAL_COUNTRY,
                                dbo.COUNTRIES.ID_PART_OF_THE_WORLD
                        FROM    dbo.COUNTRIES
        ";


            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlDB, f3.sqlCon);
            DataTable dtTable = new DataTable();
            sqlDA.Fill(dtTable);
            List<Country> lmf4 = new List<Country>();
            for (int i = 0; i < dtTable.Rows.Count; i++)
            {
                Country tem = new Country();
                tem.ID_COUNTRY = (int)dtTable.Rows[i]["ID_COUNTRY"];
                tem.NAME_COUNTRY = dtTable.Rows[i]["NAME_COUNTRY"].ToString();
                tem.POPULATION_COUNTRY = (int)dtTable.Rows[i]["POPULATION_COUNTRY"];
                tem.ABBR_COUNTRY = dtTable.Rows[i]["ABBR_COUNTRY"].ToString();
                tem.CAPITAL_COUNTRY = dtTable.Rows[i]["CAPITAL_COUNTRY"].ToString();
                tem.ID_PART_OF_THE_WORLD = (int)dtTable.Rows[i]["ID_PART_OF_THE_WORLD"];


                lmf4.Add(tem);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lmf4;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void getComboboxData2()
        {
            string sqlDB;
            sqlDB = @"SELECT    dbo.PARTS_OF_THE_WORLD.ID_PART_OF_THE_WORLD,
                                dbo.PARTS_OF_THE_WORLD.NAME_PART_OF_THE_WORLD
                        FROM    dbo.PARTS_OF_THE_WORLD
        ";

            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlDB, f3.sqlCon);
            DataTable dtTable = new DataTable();
            sqlDA.Fill(dtTable);
            List<Part_of_the_world> lmf5 = new List<Part_of_the_world>();
            for (int i = 0; i < dtTable.Rows.Count; i++)
            {
                Part_of_the_world t = new Part_of_the_world();
                t.ID_PART_OF_THE_WORLD = (int)dtTable.Rows[i]["ID_PART_OF_THE_WORLD"];
                t.NAME_PART_OF_THE_WORLD = dtTable.Rows[i]["NAME_PART_OF_THE_WORLD"].ToString();


                lmf5.Add(t);
            }
            comboBox1Partoftheworld.DataSource = null;
            comboBox1Partoftheworld.DataSource = lmf5;



        }

    }
    

}
