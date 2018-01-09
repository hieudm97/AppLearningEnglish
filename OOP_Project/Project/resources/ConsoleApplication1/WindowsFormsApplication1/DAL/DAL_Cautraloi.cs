using System;
using System.Collections.Generic;
using WindowsFormsApplication1.DATABASE;
using System.Linq;

namespace WindowsFormsApplication1.DAL
{
    internal class DAL_Cautraloi
    {
        OOP_PROJECTEntities db = new OOP_PROJECTEntities();
        public DAL_Cautraloi()
        {
        }

        internal List<Cautraloi> getCauTraLoi(int iD)
        {
            var ans = (from quanly in db.Quanlies
                       join cautraloi in db.Cautralois on quanly.ID_CAUTRALOI equals cautraloi.ID
                       where quanly.ID_CAUHOI == iD
                       select new
                       {
                           ID = cautraloi.ID,
                           NOIDUNG = cautraloi.NOIDUNG
                       }).ToList();
            List<Cautraloi> cautralois = new List<Cautraloi>();
            foreach(var tmp in ans)
            {
                Cautraloi cautraloi = new Cautraloi(tmp.ID, tmp.NOIDUNG);
                cautralois.Add(cautraloi);
            }
            return cautralois;
        }

        internal Cautraloi getCauTraLoiDung(int? iD)
        {
            var cautraloi = db.Cautralois.Where(ans => ans.ID == iD).First();
            Cautraloi tmp = new Cautraloi(cautraloi.ID, cautraloi.NOIDUNG);
            return tmp;
        }
    }
}