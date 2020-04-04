using System;

namespace ves.BL
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
