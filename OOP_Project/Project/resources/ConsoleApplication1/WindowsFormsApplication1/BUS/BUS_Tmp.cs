using System;
using WindowsFormsApplication1.DATABASE;

namespace WindowsFormsApplication1.BUS
{
    internal class BUS_Tmp
    {
        DAL.DAL_Tmp dal_tmp = new DAL.DAL_Tmp();
        internal int getSoTopicDaHoc(int iD)
        {
            return dal_tmp.getSoTopicDaHoc(iD);
        }

        internal void xuLyGiuHoacTangSoTopic(Nguoidung nguoidung, Topic topic)
        {
            bool checkTopic = dal_tmp.checkDaHocHayChua(nguoidung, topic);
            if (!checkTopic)
            {
                dal_tmp.nguoiDungVuaHoc(nguoidung, topic);
            }
        }
    }
}