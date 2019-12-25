using DAL;
using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{   
    public class OkulBL:IDisposable
    { YurtContext ctx = new YurtContext();

        public void Dispose()
        {
            ((IDisposable)ctx).Dispose();
        }

        public List<Okul> okulListesi()
        {
            List<Okul> okulList = ctx.Okullar.ToList();
            return okulList;
        }
        
    }
}
