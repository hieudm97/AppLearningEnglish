using System;
using System.Collections.Generic;
using WindowsFormsApplication1.DATABASE;
using System.Linq;

namespace WindowsFormsApplication1.DAL
{
    internal class DAL_Cauhoi
    {
        OOP_PROJECTEntities db = new OOP_PROJECTEntities();
        public DAL_Cauhoi()
        {
        }

        internal List<Cauhoi> getCauhoi(int iD)
        {
            var join = (from chitietbaitap in db.Chitietbaitaps
                        join cauhoi in db.Cauhois on chitietbaitap.ID_CAUHOI equals cauhoi.ID
                        where chitietbaitap.ID_BAITAP == iD
                        select new
                        {
                            ID = cauhoi.ID,
                            NOIDUNG = cauhoi.NOIDUNG,
                            CORRECT_ANS_ID = cauhoi.CORRECT_ANS_ID,
                            PATH_IMAGE = cauhoi.PATH_IMAGE 
                        }).ToList();
            List<Cauhoi> lst_cauhoi = new List<Cauhoi>();
            foreach(var tmp in join)
            {
                Cauhoi cauhoi = new Cauhoi(tmp.ID, tmp.NOIDUNG, tmp.CORRECT_ANS_ID, tmp.PATH_IMAGE);
                lst_cauhoi.Add(cauhoi);
            }
            return lst_cauhoi;
        }
    }
}