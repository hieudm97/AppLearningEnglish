using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApplication1.DATABASE;

namespace WindowsFormsApplication1.DAL
{
    internal class DAL_Baihoc
    {
        OOP_PROJECTEntities db = new OOP_PROJECTEntities();

        internal List<Baihoc> getBaiHoc(int id)
        {
            List<Baihoc> lst_baihoc = new List<Baihoc>();
            var list_baihoc = (from tmp2 in db.TMP2
                              join baihoc in db.Baihocs on tmp2.ID_BAIHOC equals baihoc.ID
                              where tmp2.ID_TOPIC == id
                              select new
                              {
                                  ID = baihoc.ID,
                                  NAME = baihoc.NAME,
                                  DESCRIPTION = baihoc.DESCRIPTION,
                                  EXPERIENCE = baihoc.EXPERIENCE
                              }
                              ).ToList();
            foreach(var tmp in list_baihoc)
            {
                Baihoc baihoc = new Baihoc(tmp.ID, tmp.NAME, tmp.DESCRIPTION, tmp.EXPERIENCE);
                lst_baihoc.Add(baihoc);
            }
            return lst_baihoc;
        }
    }
}