using System;
using System.Collections.Generic;
using WindowsFormsApplication1.DATABASE;

namespace WindowsFormsApplication1.BUS
{
    internal class BUS_Noidung
    {
        DAL.DAL_Noidung dal_noidung = new DAL.DAL_Noidung();
        internal List<Noidung> getNoidung(int iD)
        {
            return dal_noidung.getNoidung(iD);
        }
    }
}