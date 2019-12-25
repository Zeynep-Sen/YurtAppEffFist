using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
   public class Okul
    {
        public int OkulID { get; set; }
        public string Okul_Ad { get; set; }
       

        public ICollection<Ogrenci> OkuldakiOgrenciler { get; set; }

    }
}
