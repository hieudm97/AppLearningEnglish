using System;
using System.Collections.Generic;
using WindowsFormsApplication1.DATABASE;

namespace WindowsFormsApplication1.BUS
{
    internal class BUS_Baitap
    {
        DAL.DAL_Baitap dal_baitap = new DAL.DAL_Baitap();
        internal List<Baitap> getBaiTap(int topicid)
        {
            return dal_baitap.getBaiTap(topicid);
        }
    }
}