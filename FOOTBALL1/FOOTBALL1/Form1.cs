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
    public partial class Form1 : Form
    {
        public static string sqlConStr = ConfigurationManager.ConnectionStrings["FB1"].ConnectionString;
        public SqlConnection sqlCon = new SqlConnection(sqlConStr);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd frm = new FormAdd(this);
            frm.ShowDialog();
            getData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCity frm = new FormCity(this);
            frm.ShowDialog();
            getData();
        }

        private void button2Country_Click(object sender, EventArgs e)
        {
            FormCountry frm = new FormCountry(this);
            frm.ShowDialog();
            getData();
        }

        private void button2LEAGUE_Click(object sender, EventArgs e)
        {
            FormLeague frm = new FormLeague(this);
            frm.ShowDialog();
            getData();
        }

        private void button2PART_Click(object sender, EventArgs e)
        {
            FormPartoftheworld frm = new FormPartoftheworld(this);
            frm.ShowDialog();
            getData();
        }

        private void getData()
        {
            string sqlDB;
            sqlDB = @"SELECT    dbo.FOOTBALL_CLUBS.ID_CLUB, 
                                dbo.FOOTBALL_CLUBS.NAME_CLUB, 
                                dbo.FOOTBALL_CLUBS.BUDGET_CLUB, 
                                dbo.FOOTBALL_CLUBS.OPENING_DATE_CLUB, 
                                dbo.FOOTBALL_CLUBS.STADIUM_CLUB,
                                dbo.FOOTBALL_CLUBS.RATING_CLUB,
                                NAME_LEAGUE,
                                NAME_CITY
                        FROM    dbo.FOOTBALL_CLUBS
                        INNER JOIN dbo.LEAGUES on (dbo.FOOTBALL_CLUBS.ID_LEAGUE = dbo.LEAGUES.ID_LEAGUE)
                        INNER JOIN dbo.CITIES on (dbo.FOOTBALL_CLUBS.ID_CITY = dbo.CITIES.ID_CITY)
        ";


            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlDB, sqlCon);
            DataTable dtTable = new DataTable();
            sqlDA.Fill(dtTable);
            List<Football_Clubs> lmf3 = new List<Football_Clubs>();

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
                temp.RATING_CLUB = dtTable.Rows[i]["RATING_CLUB"].ToString();
                temp.city.NAME_CITY = dtTable.Rows[i]["NAME_CITY"].ToString();
                temp.league.NAME_LEAGUE = dtTable.Rows[i]["NAME_LEAGUE"].ToString();

                lmf3.Add(temp);
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = lmf3;
        }

        private void buttonglavniedannie_Click(object sender, EventArgs e)
        {
            getData();
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
