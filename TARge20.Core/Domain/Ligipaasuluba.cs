using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Ligipaasuluba
    {
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public Ligipaasuloa_tyyp Ligipaasuloa_tyyp { get; set; }
        public int Tootaja_Id { get; set; }
        public int Ligipaasuloa_tyyp_Id { get; set; }
        public int Ligipaasu_algus { get; set; }
        public int Ligipaasu_lopp { get; set; }
    }
}
