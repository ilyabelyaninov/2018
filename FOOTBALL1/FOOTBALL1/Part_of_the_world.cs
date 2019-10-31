using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOOTBALL1
{
    class Part_of_the_world
    {        

        public int ID_PART_OF_THE_WORLD { get; set; }
        public string NAME_PART_OF_THE_WORLD { get; set; }

        public Part_of_the_world()
        {

        }

        public Part_of_the_world(int id_chasti_sveta, string imya_chasti_sveta)
        {
            ID_PART_OF_THE_WORLD = id_chasti_sveta;
            NAME_PART_OF_THE_WORLD = imya_chasti_sveta;
        }
    }

    
}
