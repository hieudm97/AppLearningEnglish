using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DATABASE;

namespace WindowsFormsApplication1.BUS
{
    public class BUS_Nguoidung
    {
        private DAL.DAL_Nguoidung dal_nguoidung = new DAL.DAL_Nguoidung();

        internal bool addUser(Nguoidung nguoidung)
        {
            return dal_nguoidung.addUser(nguoidung);
        }

        internal bool checkNguoidung(Nguoidung nguoidung)
        {
            return dal_nguoidung.checkNguoidung(nguoidung);
        }
    }
}
