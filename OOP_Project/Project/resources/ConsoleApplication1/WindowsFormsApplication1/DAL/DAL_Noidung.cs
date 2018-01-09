using System;
using System.Collections.Generic;
using WindowsFormsApplication1.DATABASE;
using System.Linq;

namespace WindowsFormsApplication1.DAL
{
    internal class DAL_Noidung
    {
        OOP_PROJECTEntities db = new OOP_PROJECTEntities();
        public DAL_Noidung()
        {
        }

        internal List<Noidung> getNoidung(int iD)
        {
            var join = (from chitietbaihoc in db.Chitietbaihocs
                        join noidung in db.Noidungs on chitietbaihoc.ID_NOIDUNG equals noidung.ID
                        where chitietbaihoc.ID_BAIHOC == iD
                        select new
                        {
                            ID = noidung.ID,
                            PATH_HINH = noidung.PATH_HINH,
                            TUVUNG = noidung.TUVUNG
                        });
            List<Noidung> lst_noidung = new List<Noidung>();
            foreach(var tmp in join)
            {
                Noidung noidung = new Noidung(tmp.ID, tmp.PATH_HINH, tmp.TUVUNG);
                lst_noidung.Add(noidung);
            }
            return lst_noidung;
        }
    }
}