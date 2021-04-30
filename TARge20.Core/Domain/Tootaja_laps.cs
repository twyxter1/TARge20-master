using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Tootaja_laps
    {
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public int Tootaja_id { get; set; }
        public int Eesnimi { get; set; }
        public int Perekonnanimi { get; set; }
        public int Synniaeg { get; set; }
        public int Kommentaar { get; set; }
    }
}
