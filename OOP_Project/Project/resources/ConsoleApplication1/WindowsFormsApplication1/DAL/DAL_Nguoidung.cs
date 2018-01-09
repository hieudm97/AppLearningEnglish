using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DATABASE;

namespace WindowsFormsApplication1.DAL
{
    class DAL_Nguoidung
    {
        OOP_PROJECTEntities db = new OOP_PROJECTEntities();
        internal bool addUser(Nguoidung nguoidung)
        {
            db.Nguoidungs.Add(nguoidung);
            db.SaveChanges();
            return true;
        }

        internal bool checkNguoidung(Nguoidung nguoidung)
        {
            var select = db.Nguoidungs;
            foreach(var tmp in select)
            {
                if (nguoidung.USERNAME.Equals(tmp.USERNAME))
                    if (nguoidung.PASSWORD.Equals(tmp.PASSWORD))
                        return true;
            }
            return false;
        }

        internal void upDateExpForUser(Nguoidung nguoidung, double? eXPERIENCE)
        {
            Nguoidung human = db.Nguoidungs.Where(tmp => tmp.ID == nguoidung.ID).First();
            human.EXPERIENCE += eXPERIENCE;
            db.SaveChanges();
        }

        internal bool checkDuplicate(Nguoidung nguoidung)
        {
            var select = db.Nguoidungs;
            foreach(var tmp in select)
            {
                if (nguoidung.USERNAME.Equals(tmp.USERNAME))
                    return true;
            }
            return false;
        }

        internal Nguoidung getNguoidung(string username)
        {
            Nguoidung nguoidung = new Nguoidung();
            var select = db.Nguoidungs;
            foreach(var tmp in select)
            {
                if (tmp.USERNAME.Equals(username))
                {
                    nguoidung = tmp;
                }
            }
            
            return nguoidung;
        }
    }
}
