using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOOTBALL1
{
    class City
    {
        public int ID_CITY { get; set; }
        public string NAME_CITY { get; set; }
        public int ID_COUNTRY { get; set; }


        public City()
        {

        }
        public City(int id_goroda, string imya_goroda, int id_strani)
        {
            ID_CITY = id_goroda;
            NAME_CITY = imya_goroda;
            ID_COUNTRY = id_strani;
        }
    }
}
 
