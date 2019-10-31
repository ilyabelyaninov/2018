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
    public partial class FormLeague : Form
    {
        public Form1 f4;
  
        public FormLeague(Form1 _f4)
        {
            InitializeComponent();
            f4 = _f4;
            getComboboxData();

        }

        private void button2qiut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1League_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1saving_Click(object sender, EventArgs e)
        {
            string lg = textBox1League.Text;
            int yj = 8;
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = string.Format(@"insert into dbo.LEAGUES (NAME_LEAGUE, ID_COUNTRY) values ('{0}', {1})", 
                lg, yj);
            command.Connection = f4.sqlCon;
            f4.sqlCon.Open();
            int l = command.ExecuteNonQuery();
            f4.sqlCon.Close();
            MessageBox.Show("Сохранение завершено");
        }

        private void dataGridViewLEAGUE1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttondannie_Click(object sender, EventArgs e)
        {
            string sqlDB;
            sqlDB = @"SELECT    dbo.LEAGUES.ID_LEAGUE,
                                dbo.LEAGUES.NAME_LEAGUE,
                                dbo.LEAGUES.ID_COUNTRY
                        FROM    dbo.LEAGUES
        ";


            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlDB, f4.sqlCon);
            DataTable dtTable = new DataTable();
            sqlDA.Fill(dtTable);
            List<Leagues> lmf3 = new List<Leagues>();
            for (int i = 0; i < dtTable.Rows.Count; i++)
            {
                Leagues te = new Leagues();
                te.ID_LEAGUE = (int)dtTable.Rows[i]["ID_LEAGUE"];
                te.NAME_LEAGUE = dtTable.Rows[i]["NAME_LEAGUE"].ToString();
                te.ID_COUNTRY = (int)dtTable.Rows[i]["ID_COUNTRY"];


                lmf3.Add(te);
            }
            dataGridViewLEAGUE1.DataSource = null;
            dataGridViewLEAGUE1.DataSource = lmf3;
        }

        private void comboBox1AbCap_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1AbCap_SelectedIndexChanged(object sender, EventArgs e)
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


            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlDB, f4.sqlCon);
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
            comboBox1AbCap.DataSource = null;
            comboBox1AbCap.DataSource = lmf4;
        }

        private void comboBox1AbCap_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
