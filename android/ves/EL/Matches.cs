using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ves.EL
{
    public class Matches
    {
        int matchid;
        string matchnumber;
        string refereeaname;
        string refereebname;
        string scorername;
        string linejudges1name;
        string linejudges2name;
        string linejudges3name;
        string linejudges4name;
        string division;
        string matchdate;
        string matchtime;
        string teamaname;
        string teamacoach;
        int teamaset1;
        int teamaset2;
        int teamaset3;
        int teamaset4;
        int teamaset5;
        int teamatimeout1;
        int teamatimeout2;
        int teamatimeout3;
        int teamatimeout4;
        int teamatimeout5;
        int teamawonsets;
        string teamaresult;
        string teambname;
        string teambcoach;
        int teambset1;
        int teambset2;
        int teambset3;
        int teambset4;
        int teambset5;
        int teambtimeout1;
        int teambtimeout2;
        int teambtimeout3;
        int teambtimeout4;
        int teambtimeout5;
        int teambwonsets;
        string teambresult;
        int currentset;
        string matchsaveddatetime;
        int bestof;


        public int Matchid { get => matchid; set => matchid = value; }
        public string Matchnumber { get => matchnumber; set => matchnumber = value; }
        public string Refereeaname { get => refereeaname; set => refereeaname = value; }
        public string Refereebname { get => refereebname; set => refereebname = value; }
        public string Scorername { get => scorername; set => scorername = value; }
        public string Linejudges1name { get => linejudges1name; set => linejudges1name = value; }
        public string Linejudges2name { get => linejudges2name; set => linejudges2name = value; }
        public string Linejudges3name { get => linejudges3name; set => linejudges3name = value; }
        public string Linejudges4name { get => linejudges4name; set => linejudges4name = value; }
        public string Division { get => division; set => division = value; }
        public string Matchdate { get => matchdate; set => matchdate = value; }
        public string Matchtime { get => matchtime; set => matchtime = value; }
        public string Teamaname { get => teamaname; set => teamaname = value; }
        public string Teamacoach { get => teamacoach; set => teamacoach = value; }
        public int Teamaset1 { get => teamaset1; set => teamaset1 = value; }
        public int Teamaset2 { get => teamaset2; set => teamaset2 = value; }
        public int Teamaset3 { get => teamaset3; set => teamaset3 = value; }
        public int Teamaset4 { get => teamaset4; set => teamaset4 = value; }
        public int Teamaset5 { get => teamaset5; set => teamaset5 = value; }
        public int Teamatimeout1 { get => teamatimeout1; set => teamatimeout1 = value; }
        public int Teamatimeout2 { get => teamatimeout2; set => teamatimeout2 = value; }
        public int Teamatimeout3 { get => teamatimeout3; set => teamatimeout3 = value; }
        public int Teamatimeout4 { get => teamatimeout4; set => teamatimeout4 = value; }
        public int Teamatimeout5 { get => teamatimeout5; set => teamatimeout5 = value; }
        public int Teamawonsets { get => teamawonsets; set => teamawonsets = value; }
        public string Teamaresult { get => teamaresult; set => teamaresult = value; }
        public string Teambname { get => teambname; set => teambname = value; }
        public string Teambcoach { get => teambcoach; set => teambcoach = value; }
        public int Teambset1 { get => teambset1; set => teambset1 = value; }
        public int Teambset2 { get => teambset2; set => teambset2 = value; }
        public int Teambset3 { get => teambset3; set => teambset3 = value; }
        public int Teambset4 { get => teambset4; set => teambset4 = value; }
        public int Teambset5 { get => teambset5; set => teambset5 = value; }
        public int Teambtimeout1 { get => teambtimeout1; set => teambtimeout1 = value; }
        public int Teambtimeout2 { get => teambtimeout2; set => teambtimeout2 = value; }
        public int Teambtimeout3 { get => teambtimeout3; set => teambtimeout3 = value; }
        public int Teambtimeout4 { get => teambtimeout4; set => teambtimeout4 = value; }
        public int Teambtimeout5 { get => teambtimeout5; set => teambtimeout5 = value; }
        public int Teambwonsets { get => teambwonsets; set => teambwonsets = value; }
        public string Teambresult { get => teambresult; set => teambresult = value; }
        public int Currentset { get => currentset; set => currentset = value; }
        public string Matchsaveddatetime { get => matchsaveddatetime; set => matchsaveddatetime = value; }
        public int Bestof { get => bestof; set => bestof = value; }
        
    }
}