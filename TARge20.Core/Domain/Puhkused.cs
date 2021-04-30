using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Puhkused
    {
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public Puhkuse_tyyp Puhkuse_tyyp { get; set; }
        public int Tootaja_Id { get; set; }
        public int Puhkuse_tyyp_Id { get; set; }
        public int Puhkuse_algus { get; set; }
        public int Puhkuse_l6pp { get; set; }
        public int Kommentaar { get; set; }
    }
}
