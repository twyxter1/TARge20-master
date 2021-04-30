using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Laenutuskord
    {
        public  Guid Id { get; set; }
        public Employee Employee { get; set; }
        public Laenutatav_ese Laenutatav_ese { get; set; }
        public int Laenutatav_ese_Id { get; set; }
        public int Tootaja_Id { get; set; }
        public int Laenutuse_algus { get; set; }
        public int Laenutuse_l6pp { get; set; }
    }
}
