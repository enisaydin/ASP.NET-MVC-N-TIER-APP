using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.Domain
{
    public class OyuncuFilm
    {
        public int CalismaGunu { get; set; }
        public int OyuncuID { get; set; }
        public OyuncuFilm Oyuncu { get; set; }
    }
}
