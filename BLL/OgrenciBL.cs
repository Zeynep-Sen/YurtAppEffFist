using DAL;
using MODELS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OgrenciBL:IDisposable
    {
        YurtContext ctx = new YurtContext();
        public bool OgrenciKaydet(Ogrenci o)
        {
            ctx.Ogrenciler.Add(o);
            return ctx.SaveChanges() > 0;
        }
        public bool OgrenciGuncelle(Ogrenci o)
        {
            ctx.Entry<Ogrenci>(o).State = EntityState.Modified;
            return ctx.SaveChanges() > 0;
        }
        public bool OgrenciSil(Ogrenci o)
        {
            ctx.Ogrenciler.Remove(o);
            return ctx.SaveChanges() > 0;
        }

        public void Dispose()
        {
            ((IDisposable)ctx).Dispose();
        }
    }
}
