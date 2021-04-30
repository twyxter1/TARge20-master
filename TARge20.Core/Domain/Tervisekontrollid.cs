using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Tervisekontrollid
    {
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public int Tootaja_Id { get; set; }
        public int Kuupaev { get; set; }
        public int Kellaaeg { get; set; }
        public int Tulemus { get; set; }
        public int Kommentaar { get; set; }
    }
}
