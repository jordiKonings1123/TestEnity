using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Stad
    {
        public int StadId { get; set; }
        [RegularExpression(@"[a-z]")]
        public string Naam { get; set; }
        public string ISOLandCode { get; set; }

        public byte[] Aangepast { get; set; }

        public virtual Land Land { get; set; }
    }
}
