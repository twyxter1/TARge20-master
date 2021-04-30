using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class T66suhe
    {
        public Guid Id { get; set; }
        public Ametinimetused Ametinimetused { get; set; }
        public Harukontor Harukontor { get; set; }
        public int Tootaja_Id { get; set; }
        public int Harukontori_Id { get; set; }
        public int Ametinimetus_Id { get; set; }
        public int Tool_alates { get; set; }
        public int Tool_kuni { get; set; }
        public int Koormus { get; set; }
    }
}
