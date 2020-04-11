using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace dashboard.DL
{
    public class Announcements
    {

        public DataTable List()
        {
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "select * from announcements";
                return methods.executeQuery(cmd);
            }
        }


        public Boolean Update(EL.Announcements announcementEL)
        {
            bool bol = false;

            using (var cmd = new MySqlCommand())
            {

                if (announcementEL.Announcementtype == 1)
                {
                    cmd.CommandText = "update announcements set announcement = @announcement, announcementtype = @announcementtype";

                    cmd.Parameters.AddWithValue("@announcement", announcementEL.Announcement.Trim());
                    cmd.Parameters.AddWithValue("@announcementtype", announcementEL.Announcementtype);
                    bol = methods.executeNonQueryBool(cmd);
                }

                if (announcementEL.Announcementtype == 2)
                {
                    cmd.CommandText = "update announcements set  announcementtextfullscreen = @announcementtextfullscreen, announcementtype = @announcementtype";

                    cmd.Parameters.AddWithValue("@announcementtextfullscreen", announcementEL.Announcementtextfullscreen.Trim());
                    cmd.Parameters.AddWithValue("@announcementtype", announcementEL.Announcementtype);
                    bol = methods.executeNonQueryBool(cmd);
                }

                if (announcementEL.Announcementtype == 3)
                {
                    cmd.CommandText = "update announcements set announcementtype = @announcementtype, announcementimage = @announcementimage";

                    cmd.Parameters.AddWithValue("@announcementtype", announcementEL.Announcementtype);
                    cmd.Parameters.AddWithValue("@announcementimage", announcementEL.Announcementimage);
                    bol = methods.executeNonQueryBool(cmd);
                }

            }

            return bol;

        }
    }
}
