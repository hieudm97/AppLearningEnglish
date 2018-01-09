using System;
using System.Collections.Generic;
using WindowsFormsApplication1.DATABASE;
using System.Linq;

namespace WindowsFormsApplication1.DAL
{
    internal class DAL_Baitap
    {
        OOP_PROJECTEntities db = new OOP_PROJECTEntities();
        public DAL_Baitap()
        {
        }

        internal List<Baitap> getBaiTap(int topicid)
        {
            List<Baitap> lst_baitap = new List<Baitap>();
            var list_baitap = (from tmp2 in db.TMP2
                               join baitap in db.Baitaps on tmp2.ID_BAITAP equals baitap.ID
                               where tmp2.ID_TOPIC == topicid
                               select new
                               {
                                   ID = baitap.ID,
                                   NAME = baitap.NAME,
                                   DESCRIPTION = baitap.DESCRIPTION,
                                   EXPERIENCE = baitap.EXPERIENCE
                               }).ToList();
            foreach (var tmp in list_baitap)
            {
                Baitap baitap = new DATABASE.Baitap(tmp.ID, tmp.NAME, tmp.DESCRIPTION, tmp.EXPERIENCE);
                lst_baitap.Add(baitap);
            }
            return lst_baitap;
        }
    }
}