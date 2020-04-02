using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace dashboard.BL
{
    public class Announcements
    {

        DL.Announcements announcementDL = new DL.Announcements();

        public DataTable List()
        {
            return announcementDL.List();
        }


        public Boolean Update(EL.Announcements announcementEL)
        {
            return announcementDL.Update(announcementEL);
        }
    }
}
