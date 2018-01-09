using System;
using System.Collections.Generic;
using WindowsFormsApplication1.DATABASE;

namespace WindowsFormsApplication1.BUS
{
    internal class BUS_Baihoc
    {
        DAL.DAL_Baihoc dal_baihoc = new DAL.DAL_Baihoc();
        internal List<Baihoc> getBaiHoc(int id)
        {
            return dal_baihoc.getBaiHoc(id);
        }
    }
}