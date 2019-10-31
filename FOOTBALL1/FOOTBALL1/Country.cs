using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOOTBALL1
{
    class Country
    {
        public int ID_COUNTRY { get; set; }
        public string NAME_COUNTRY { get; set; }
        public int POPULATION_COUNTRY { get; set; }
        public string ABBR_COUNTRY { get; set; }
        public string CAPITAL_COUNTRY { get; set; }
        public int ID_PART_OF_THE_WORLD { get; set; }

        public Country()
        {

        }
        public Country(int id_strani, string imya_strani, int naselenie, string abbr_strani, string stolitsa, int id_chasti_sveta)
        {
            ID_COUNTRY = id_strani;
            NAME_COUNTRY = imya_strani;
            POPULATION_COUNTRY = naselenie;
            ABBR_COUNTRY = abbr_strani;
            CAPITAL_COUNTRY = stolitsa;
            ID_PART_OF_THE_WORLD = id_chasti_sveta;
        }

    }
    
}
