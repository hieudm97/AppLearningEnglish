using System;
using System.Linq;
using WindowsFormsApplication1.DATABASE;
namespace WindowsFormsApplication1.DAL
{
    internal class DAL_Tmp
    {
        OOP_PROJECTEntities db = new OOP_PROJECTEntities();
        internal int getSoTopicDaHoc(int iD)
        {
            return db.Tmps.Count(t => t.ID_USER == iD);
        }

        internal bool checkDaHocHayChua(Nguoidung nguoidung, Topic topic)
        {
            var select = db.Tmps.Where(tmp => tmp.ID_USER == nguoidung.ID).ToList();

            foreach(var tmp in select)
            {
                if (tmp.ID_TOPIC == topic.ID)
                    return true;
            }
            return false;
        }

        internal void nguoiDungVuaHoc(Nguoidung nguoidung, Topic topic)
        {
            Tmp tmp = new Tmp(nguoidung.ID, topic.ID);
            db.Tmps.Add(tmp);
            db.SaveChanges();
        }
    }
}