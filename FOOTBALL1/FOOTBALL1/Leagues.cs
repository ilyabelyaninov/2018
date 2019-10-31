using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOOTBALL1
{
    class Leagues
    {
        public Leagues league { get; set; }
        public int ID_LEAGUE { get; set; }
        public string NAME_LEAGUE { get; set; }
        public int ID_COUNTRY { get; set; }

        public Leagues()
        {

        }
        public Leagues(int id_ligi, string imya_ligi, int id_strani)
        {
            ID_LEAGUE = id_ligi;
            NAME_LEAGUE = imya_ligi;
            ID_COUNTRY = id_strani;
        }
    }
}
