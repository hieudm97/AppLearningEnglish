using System;
using System.Collections.Generic;
using WindowsFormsApplication1.DATABASE;

namespace WindowsFormsApplication1.BUS
{
    internal class BUS_Cauhoi
    {
        DAL.DAL_Cauhoi dal_cauhoi = new DAL.DAL_Cauhoi();
        public BUS_Cauhoi()
        {
        }

        internal List<Cauhoi> getCauHoi(int iD)
        {
            return dal_cauhoi.getCauhoi(iD);
        }
    }
}