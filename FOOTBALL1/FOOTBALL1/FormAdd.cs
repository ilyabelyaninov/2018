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
    public partial class FormAdd : Form
    {
        //Добавили переменную класса основной формы, через нее обращаемся к переменной подключения
        public Form1 f1;
        public FormAdd(Form1 _f1)
        {
            InitializeComponent();
            f1 = _f1;
            getComboboxData();
            getComboboxData1();
        }

        private void comboBoxLeague_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStadium_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxClub_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBudget_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1Save_Click(object sender, EventArgs e)
        {

            string gender = textBoxClub.Text;
            string qw = textBoxBudget.Text;
            string we = textBoxStadium.Text;
            int rt = 5;
            int ty = 4;
            string yu = textBoxYear.Text;
            string jk = textBox1Rating.Text;
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = string.Format (@"insert into dbo.FOOTBALL_CLUBS (NAME_CLUB, BUDGET_CLUB,
            STADIUM_CLUB, city.NAME_CITY, league.NAME_LEAGUE, OPENING_DATE_CLUB, RATING_CLUB)  
                                    values ('{0}', '{1}', '{2}', {3}, {4}, '{5}', '{6}')",
                                   gender, qw, we, rt, ty, yu, jk);
            command.Connection = f1.sqlCon;
            f1.sqlCon.Open();
            int m = command.ExecuteNonQuery();
            f1.sqlCon.Close();
            MessageBox.Show ("Сохранение завершено");
        }

        private void textBox1Rating_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPokazatDannye_Click(object sender, EventArgs e)
        {
            string sqlDB;
            sqlDB = @"SELECT    dbo.FOOTBALL_CLUBS.ID_CLUB, 
                                dbo.FOOTBALL_CLUBS.NAME_CLUB, 
                                dbo.FOOTBALL_CLUBS.BUDGET_CLUB, 
                                dbo.FOOTBALL_CLUBS.OPENING_DATE_CLUB, 
                                dbo.FOOTBALL_CLUBS.STADIUM_CLUB,
                                dbo.FOOTBALL_CLUBS.ID_LEAGUE,
                                dbo.FOOTBALL_CLUBS.ID_CITY,
                                dbo.FOOTBALL_CLUBS.RATING_CLUB
                        FROM    dbo.FOOTBALL_CLUBS
        ";

          
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlDB, f1.sqlCon);
            DataTable dtTable = new DataTable();
            sqlDA.Fill(dtTable);
            List<Football_Clubs> lmf3 = new List<Football_Clubs> ();
            for (int i = 0; i < dtTable.Rows.Count; i++)
            {
                Football_Clubs temp = new Football_Clubs();
                temp.city = new City();
                temp.league = new Leagues();
                temp.ID_CLUB = (int)dtTable.Rows[i]["ID_CLUB"];
                temp.NAME_CLUB = dtTable.Rows[i]["NAME_CLUB"].ToString();
                temp.BUDGET_CLUB = dtTable.Rows[i]["BUDGET_CLUB"].ToString();
                temp.OPENING_DATE_CLUB = dtTable.Rows[i]["OPENING_DATE_CLUB"].ToString();
                temp.STADIUM_CLUB = dtTable.Rows[i]["STADIUM_CLUB"].ToString();
                temp.league.ID_LEAGUE = (int)dtTable.Rows[i]["ID_LEAGUE"];
                temp.city.ID_CITY = (int)dtTable.Rows[i]["ID_CITY"];
                temp.RATING_CLUB = dtTable.Rows[i]["RATING_CLUB"].ToString();

                lmf3.Add(temp);
            }
            dataGridViewFootballClubs.DataSource = null;
            dataGridViewFootballClubs.DataSource = lmf3;
        }

        private void dataGridViewFootballClubs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void getComboboxData()
        {
            string sqlDB;
            sqlDB = @"SELECT    dbo.CITIES.ID_CITY,
                                dbo.CITIES.NAME_CITY,
                                dbo.CITIES.ID_COUNTRY
                        FROM    dbo.CITIES 
        ";


            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlDB, f1.sqlCon);
            DataTable dtTableB = new DataTable();
            sqlDA.Fill(dtTableB);
            List<City> lmf9 = new List<City>();
            for (int i = 0; i < dtTableB.Rows.Count; i++)
            {
                City temp = new City();
                temp.ID_CITY = (int)dtTableB.Rows[i]["ID_CITY"];
                temp.NAME_CITY = dtTableB.Rows[i]["NAME_CITY"].ToString();
                temp.ID_COUNTRY = (int)dtTableB.Rows[i]["ID_COUNTRY"];


                lmf9.Add(temp);
            }
            comboBoxCity.DataSource = null;
            comboBoxCity.DataSource = lmf9;

        }

        public void getComboboxData1()
        {
            string sqlDB;
            sqlDB = @"SELECT    dbo.LEAGUES.ID_LEAGUE,
                                dbo.LEAGUES.NAME_LEAGUE,
                                dbo.LEAGUES.ID_COUNTRY
                        FROM    dbo.LEAGUES
        ";


            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlDB, f1.sqlCon);
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
            comboBoxLeague.DataSource = null;
            comboBoxLeague.DataSource = lmf3;
        }
      
        
    }
}
