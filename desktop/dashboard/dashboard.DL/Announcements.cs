using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

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
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "update announcements set announcement = @announcement";

                cmd.Parameters.AddWithValue("@announcement", announcementEL.Announcement.Trim());
                return methods.executeNonQueryBool(cmd);
            }
        }
    }
}
