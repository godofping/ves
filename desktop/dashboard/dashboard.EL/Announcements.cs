using System;
using System.Collections.Generic;
using System.Text;

namespace dashboard.EL
{
    public class Announcements
    {
        string announcement;
        string announcementtextfullscreen;
        int announcementtype;
        string announcementimage;

        public string Announcement { get => announcement; set => announcement = value; }
        public string Announcementtextfullscreen { get => announcementtextfullscreen; set => announcementtextfullscreen = value; }
        public int Announcementtype { get => announcementtype; set => announcementtype = value; }
        public string Announcementimage { get => announcementimage; set => announcementimage = value; }
    }
}
