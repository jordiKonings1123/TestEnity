using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Stad
    {
        public int StadId { get; set; }
        public string Naam { get; set; }
        public string ISOLandCode { get; set; }

        public byte[] Aangepast { get; set; }

        public virtual Land Land { get; set; }
    }
}
