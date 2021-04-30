using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Palved
    {
        public Guid Id { get; set; }
        public int Saaja_Id { get; set; }
        public int Saatja_Id { get; set; }
        public int Kuupaev { get; set; }
        public int Kommentaar { get; set; }
    }
}
