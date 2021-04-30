using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
   public class Haiguslehed
    {
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public Haiguslehe_tyyp Haiguslehe_tyyp { get; set; }
        public int Tootaja_Id { get; set; }
        public int Haiguslehe_tyyp_Id { get; set; }
        public int Haiguslehe_algus { get; set; }
        public int Haiguslehe_l6pp { get; set; }
        public int Kommentaar { get; set; }
    }
}
