using System;
using System.Collections.Generic;
using WindowsFormsApplication1.DATABASE;

namespace WindowsFormsApplication1.BUS
{
    internal class BUS_Cautraloi
    {
        DAL.DAL_Cautraloi dal_cautraloi = new DAL.DAL_Cautraloi();
        internal List<Cautraloi> getCauTraLoi(int iD)
        {
            return dal_cautraloi.getCauTraLoi(iD);
        }

        internal Cautraloi getCauTraLoiDung(int? iD)
        {
            return dal_cautraloi.getCauTraLoiDung(iD);
        }

    }
}