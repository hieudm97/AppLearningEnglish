using System;

namespace WindowsFormsApplication1.BUS
{
    internal class BUS_Tmp
    {
        DAL.DAL_Tmp dal_tmp = new DAL.DAL_Tmp();
        internal int getSoTopicDaHoc(int iD)
        {
            return dal_tmp.getSoTopicDaHoc(iD);
        }
    }
}