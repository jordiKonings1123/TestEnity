using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class LandTaal
    {
        public string ISOLandCode { get; set; }
        public string ISOTaalCode { get; set; }
        public virtual Land Land { get; set; }
        public virtual Taal Taal { get; set; }
    }
}
