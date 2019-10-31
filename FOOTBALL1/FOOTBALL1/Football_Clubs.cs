using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FOOTBALL1
{
    class Football_Clubs
    {
        public int ID_CLUB { get; set; }
        public string NAME_CLUB { get; set; }
        public string BUDGET_CLUB { get; set; }
        public string OPENING_DATE_CLUB { get; set; }
        public string STADIUM_CLUB { get; set; }
       // public int ID_LEAGUE { get; set; } 
        public Leagues league { get; set; }
       // public int ID_CITY { get; set; }
        public City city { get; set; }
        public string RATING_CLUB { get; set; }

        public Football_Clubs()
        {

        }

        public Football_Clubs(SqlConnection sqlCon, int id_kluba, string imya_kluba, string budzhet_kluba, string god_otkritiya_kluba, string stadion_kluba, int id_ligi, int id_goroda, string reiting_cluba)
        {
            ID_CLUB = id_kluba;
            NAME_CLUB = imya_kluba;
            BUDGET_CLUB = budzhet_kluba;
            OPENING_DATE_CLUB = god_otkritiya_kluba;
            STADIUM_CLUB = stadion_kluba;
            league.ID_LEAGUE = id_ligi;
            string sqlDB;
            sqlDB = @"SELECT NAME_LEAGUE,  
                            ID_COUNTRY
                        FROM dbo.LEAGUES 
                       WHERE ID_LEAGUE = " + id_ligi;

            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlDB, sqlCon);
            DataTable dtTable = new DataTable();
            sqlDA.Fill(dtTable);

            Leagues temp = new Leagues(); ;
            for (int i = 0; i < dtTable.Rows.Count; i++)
            {
                temp.NAME_LEAGUE = dtTable.Rows[i]["NAME_LEAGUE"].ToString();
                temp.ID_COUNTRY = (int)dtTable.Rows[i]["ID_COUNTRY"];
            }
            league = temp;
            string sqlDC;
            city.ID_CITY = id_goroda;
            sqlDC = @"SELECT NAME_CITY,
                             ID_COUNTRY
                      FROM dbo.CITIES
                      WHERE ID_CITY = " + id_goroda;
            SqlDataAdapter sqlDD = new SqlDataAdapter(sqlDC, sqlCon);
            DataTable dtTable2 = new DataTable();
            sqlDD.Fill(dtTable2);

            City tem = new City();
            for (int i = 0; i < dtTable2.Rows.Count; i++)
            {
                tem.NAME_CITY = dtTable2.Rows[i]["NAME_CITY"].ToString();
                tem.ID_COUNTRY = (int)dtTable2.Rows[i]["ID_COUNTRY"];
            }
            city = tem;
            
            RATING_CLUB = reiting_cluba;
        }
    }
}
