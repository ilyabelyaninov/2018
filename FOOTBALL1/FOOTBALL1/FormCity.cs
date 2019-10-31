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
    public partial class FormCity : Form
    {
        public Form1 f2;
        public FormCity(Form1 _f2)
        {
            InitializeComponent();
            f2 = _f2;
            getComboboxData();
        }

        private void textBoxCity1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1Save_Click(object sender, EventArgs e)
        {
            string nm = textBoxCity1.Text;
            int kl = 8;
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = string.Format(@"insert into dbo.CITIES (NAME_CITY, ID_COUNTRY) values ('{0}', {1})",
                nm, kl);
            command.Connection = f2.sqlCon;
            f2.sqlCon.Open();
            int b = command.ExecuteNonQuery();
            f2.sqlCon.Close();
            MessageBox.Show("Сохранение завершено");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1Pokazatdannie_Click(object sender, EventArgs e)
        {
            string sqlDB;
            sqlDB = @"SELECT    [dbo].[CITIES].ID_CITY,
                                [dbo].[CITIES].NAME_CITY,
                                [dbo].[CITIES].ID_COUNTRY
                        FROM    [dbo].[CITIES] 
        ";


            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlDB, f2.sqlCon);
            DataTable dtTableB = new DataTable();
            sqlDA.Fill(dtTableB);
            List<City> lmf3 = new List<City>();
            for (int i = 0; i < dtTableB.Rows.Count; i++)
            {
                City temp = new City();
                temp.ID_CITY = (int)dtTableB.Rows[i]["ID_CITY"];
                temp.NAME_CITY = dtTableB.Rows[i]["NAME_CITY"].ToString();
                temp.ID_COUNTRY = (int)dtTableB.Rows[i]["ID_COUNTRY"];


                lmf3.Add(temp);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lmf3;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void getComboboxData()
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


            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlDB, f2.sqlCon);
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
            comboBoxCountry.DataSource = null;
            comboBoxCountry.DataSource = lmf4;
        }
    }

}

