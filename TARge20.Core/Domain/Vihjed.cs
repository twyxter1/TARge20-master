using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Vihjed
    {
        public Guid Id { get; set; }
        public int Saaja_id { get; set; }
        public int Kuupaev { get; set; }
        public int Kommentaar { get; set; }
    }
}
