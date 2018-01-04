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
    }
}