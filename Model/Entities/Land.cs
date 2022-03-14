using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Land
    {
        public string ISOLandCode { get; set; }


        public string NISLandCode { get; set; }
        public string Naam { get; set; }
        public int AantalInwoners { get; set; }
        public float Oppervlakte { get; set; }

        public byte[] Aangepast { get; set; }

        public virtual ICollection<Stad> Steden { get; set; } = new List<Stad>();
        public virtual ICollection<LandTaal> LandTaal { get; set; } = new List<LandTaal>();

    }
}
