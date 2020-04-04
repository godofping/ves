using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ves.DL
{
    public class Matches
    {

        public DataTable List(string str)
        {
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT matchid, matchnumber, teamaname, teambname, matchdate, matchtime, matchsaveddatetime FROM matches where matchid <> 1 and (matchnumber like @str or teamaname like @str or teambname like @str or matchdate like @str or matchtime like @str or matchsaveddatetime like @str)";
                cmd.Parameters.AddWithValue("@str", str + "%");
                return methods.executeQuery(cmd);
            }
        }

        public long Insert(EL.Matches matchEL)
        {
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "insert into  matches set matchnumber = @matchnumber, refereename = @refereename, scorername = @scorername, linejudges1name = @linejudges1name, linejudges2name = @linejudges2name, linejudges3name = @linejudges3name, linejudges4name = @linejudges4name, division = @division, matchdate = @matchdate, matchtime = @matchtime, teamaname = @teamaname, teamacoach = @teamacoach, teamaset1 = @teamaset1, teamaset2 = @teamaset2, teamaset3 = @teamaset3, teamaset4 = @teamaset4, teamaset5 = @teamaset5, teamatimeout1 = @teamatimeout1, teamatimeout2= @teamatimeout2, teamatimeout3 = @teamatimeout3, teamatimeout4 = @teamatimeout4, teamatimeout5 = @teamatimeout5, teamawonsets = @teamawonsets,teamaresult= @teamaresult, teambname = @teambname, teambcoach = @teambcoach, teambset1= @teambset1, teambset2 = @teambset2,  teambset3 = @teambset3, teambset4 = @teambset4, teambset5 = @teambset5, teambtimeout1 = @teambtimeout1, teambtimeout2 = @teambtimeout2,  teambtimeout3 = @teambtimeout3, teambtimeout4 = @teambtimeout4, teambtimeout5 = @teambtimeout5, teambwonsets = @teambwonsets, teambresult = @teambresult, currentset = @currentset, matchsaveddatetime = @matchsaveddatetime, bestof = @bestof";

                cmd.Parameters.AddWithValue("@matchid", matchEL.Matchid);
                cmd.Parameters.AddWithValue("@matchnumber", matchEL.Matchnumber);
                cmd.Parameters.AddWithValue("@refereename", matchEL.Refereename);
                cmd.Parameters.AddWithValue("@scorername", matchEL.Scorername);
                cmd.Parameters.AddWithValue("@linejudges1name", matchEL.Linejudges1name);
                cmd.Parameters.AddWithValue("@linejudges2name", matchEL.Linejudges2name);
                cmd.Parameters.AddWithValue("@linejudges3name", matchEL.Linejudges3name);
                cmd.Parameters.AddWithValue("@linejudges4name", matchEL.Linejudges4name);
                cmd.Parameters.AddWithValue("@division", matchEL.Division);
                cmd.Parameters.AddWithValue("@matchdate", matchEL.Matchdate);
                cmd.Parameters.AddWithValue("@matchtime", matchEL.Matchtime);
                cmd.Parameters.AddWithValue("@teamaname", matchEL.Teamaname);
                cmd.Parameters.AddWithValue("@teamacoach", matchEL.Teamacoach);
                cmd.Parameters.AddWithValue("@teamaset1", matchEL.Teamaset1);
                cmd.Parameters.AddWithValue("@teamaset2", matchEL.Teamaset2);
                cmd.Parameters.AddWithValue("@teamaset3", matchEL.Teamaset3);
                cmd.Parameters.AddWithValue("@teamaset4", matchEL.Teamaset4);
                cmd.Parameters.AddWithValue("@teamaset5", matchEL.Teamaset5);
                cmd.Parameters.AddWithValue("@teamatimeout1", matchEL.Teamatimeout1);
                cmd.Parameters.AddWithValue("@teamatimeout2", matchEL.Teamatimeout2);
                cmd.Parameters.AddWithValue("@teamatimeout3", matchEL.Teamatimeout3);
                cmd.Parameters.AddWithValue("@teamatimeout4", matchEL.Teamatimeout4);
                cmd.Parameters.AddWithValue("@teamatimeout5", matchEL.Teamatimeout5);
                cmd.Parameters.AddWithValue("@teamawonsets", matchEL.Teamawonsets);
                cmd.Parameters.AddWithValue("@teamaresult", matchEL.Teamaresult);
                cmd.Parameters.AddWithValue("@teambname", matchEL.Teambname);
                cmd.Parameters.AddWithValue("@teambcoach", matchEL.Teambcoach);
                cmd.Parameters.AddWithValue("@teambset1", matchEL.Teambset1);
                cmd.Parameters.AddWithValue("@teambset2", matchEL.Teambset2);
                cmd.Parameters.AddWithValue("@teambset3", matchEL.Teambset3);
                cmd.Parameters.AddWithValue("@teambset4", matchEL.Teambset4);
                cmd.Parameters.AddWithValue("@teambset5", matchEL.Teambset5);
                cmd.Parameters.AddWithValue("@teambtimeout1", matchEL.Teambtimeout1);
                cmd.Parameters.AddWithValue("@teambtimeout2", matchEL.Teambtimeout2);
                cmd.Parameters.AddWithValue("@teambtimeout3", matchEL.Teambtimeout3);
                cmd.Parameters.AddWithValue("@teambtimeout4", matchEL.Teambtimeout4);
                cmd.Parameters.AddWithValue("@teambtimeout5", matchEL.Teambtimeout5);
                cmd.Parameters.AddWithValue("@teambwonsets", matchEL.Teambwonsets);
                cmd.Parameters.AddWithValue("@teambresult", matchEL.Teambresult);
                cmd.Parameters.AddWithValue("@currentset", matchEL.Currentset);
                cmd.Parameters.AddWithValue("@matchsaveddatetime", matchEL.Matchsaveddatetime);
                cmd.Parameters.AddWithValue("@bestof", matchEL.Bestof);

                return methods.executeNonQueryLong(cmd);
            }
        }

        public Boolean Update(EL.Matches matchEL)
        {
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "update matches set matchnumber = @matchnumber, refereename = @refereename, scorername = @scorername, linejudges1name = @linejudges1name, linejudges2name = @linejudges2name, linejudges3name = @linejudges3name, linejudges4name = @linejudges4name, division = @division, matchdate = @matchdate, matchtime = @matchtime, teamaname = @teamaname, teamacoach = @teamacoach, teamaset1 = @teamaset1, teamaset2 = @teamaset2, teamaset3 = @teamaset3, teamaset4 = @teamaset4, teamaset5 = @teamaset5, teamatimeout1 = @teamatimeout1, teamatimeout2= @teamatimeout2, teamatimeout3 = @teamatimeout3, teamatimeout4 = @teamatimeout4, teamatimeout5 = @teamatimeout5, teamawonsets = @teamawonsets,teamaresult= @teamaresult, teambname = @teambname, teambcoach = @teambcoach, teambset1= @teambset1, teambset2 = @teambset2,  teambset3 = @teambset3, teambset4 = @teambset4, teambset5 = @teambset5, teambtimeout1 = @teambtimeout1, teambtimeout2 = @teambtimeout2,  teambtimeout3 = @teambtimeout3, teambtimeout4 = @teambtimeout4, teambtimeout5 = @teambtimeout5, teambwonsets = @teambwonsets, teambresult = @teambresult, currentset = @currentset, bestof = @bestof where matchid = @matchid";

                cmd.Parameters.AddWithValue("@matchid", matchEL.Matchid);
                cmd.Parameters.AddWithValue("@matchnumber", matchEL.Matchnumber);
                cmd.Parameters.AddWithValue("@refereename", matchEL.Refereename);
                cmd.Parameters.AddWithValue("@scorername", matchEL.Scorername);
                cmd.Parameters.AddWithValue("@linejudges1name", matchEL.Linejudges1name);
                cmd.Parameters.AddWithValue("@linejudges2name", matchEL.Linejudges2name);
                cmd.Parameters.AddWithValue("@linejudges3name", matchEL.Linejudges3name);
                cmd.Parameters.AddWithValue("@linejudges4name", matchEL.Linejudges4name);
                cmd.Parameters.AddWithValue("@division", matchEL.Division);
                cmd.Parameters.AddWithValue("@matchdate", matchEL.Matchdate);
                cmd.Parameters.AddWithValue("@matchtime", matchEL.Matchtime);
                cmd.Parameters.AddWithValue("@teamaname", matchEL.Teamaname);
                cmd.Parameters.AddWithValue("@teamacoach", matchEL.Teamacoach);
                cmd.Parameters.AddWithValue("@teamaset1", matchEL.Teamaset1);
                cmd.Parameters.AddWithValue("@teamaset2", matchEL.Teamaset2);
                cmd.Parameters.AddWithValue("@teamaset3", matchEL.Teamaset3);
                cmd.Parameters.AddWithValue("@teamaset4", matchEL.Teamaset4);
                cmd.Parameters.AddWithValue("@teamaset5", matchEL.Teamaset5);
                cmd.Parameters.AddWithValue("@teamatimeout1", matchEL.Teamatimeout1);
                cmd.Parameters.AddWithValue("@teamatimeout2", matchEL.Teamatimeout2);
                cmd.Parameters.AddWithValue("@teamatimeout3", matchEL.Teamatimeout3);
                cmd.Parameters.AddWithValue("@teamatimeout4", matchEL.Teamatimeout4);
                cmd.Parameters.AddWithValue("@teamatimeout5", matchEL.Teamatimeout5);
                cmd.Parameters.AddWithValue("@teamawonsets", matchEL.Teamawonsets);
                cmd.Parameters.AddWithValue("@teamaresult", matchEL.Teamaresult);
                cmd.Parameters.AddWithValue("@teambname", matchEL.Teambname);
                cmd.Parameters.AddWithValue("@teambcoach", matchEL.Teambcoach);
                cmd.Parameters.AddWithValue("@teambset1", matchEL.Teambset1);
                cmd.Parameters.AddWithValue("@teambset2", matchEL.Teambset2);
                cmd.Parameters.AddWithValue("@teambset3", matchEL.Teambset3);
                cmd.Parameters.AddWithValue("@teambset4", matchEL.Teambset4);
                cmd.Parameters.AddWithValue("@teambset5", matchEL.Teambset5);
                cmd.Parameters.AddWithValue("@teambtimeout1", matchEL.Teambtimeout1);
                cmd.Parameters.AddWithValue("@teambtimeout2", matchEL.Teambtimeout2);
                cmd.Parameters.AddWithValue("@teambtimeout3", matchEL.Teambtimeout3);
                cmd.Parameters.AddWithValue("@teambtimeout4", matchEL.Teambtimeout4);
                cmd.Parameters.AddWithValue("@teambtimeout5", matchEL.Teambtimeout5);
                cmd.Parameters.AddWithValue("@teambwonsets", matchEL.Teambwonsets);
                cmd.Parameters.AddWithValue("@teambresult", matchEL.Teambresult);
                cmd.Parameters.AddWithValue("@currentset", matchEL.Currentset);
                cmd.Parameters.AddWithValue("@bestof", matchEL.Bestof);

                return methods.executeNonQueryBool(cmd);
            }
        }

        public EL.Matches Select(EL.Matches matchEL)
        {

            DataTable dt = null;

            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "select * from matches where matchid = @matchid";

                cmd.Parameters.AddWithValue("@matchid", matchEL.Matchid);

                dt = methods.executeQuery(cmd);
            }

            if (dt.Rows.Count > 0)
            {
                matchEL.Matchid = Convert.ToInt32(dt.Rows[0]["matchid"]);
                matchEL.Matchnumber = dt.Rows[0]["matchnumber"].ToString();
                matchEL.Refereename = dt.Rows[0]["refereename"].ToString();
                matchEL.Linejudges1name = dt.Rows[0]["linejudges1name"].ToString();
                matchEL.Linejudges2name = dt.Rows[0]["linejudges2name"].ToString();
                matchEL.Linejudges3name = dt.Rows[0]["linejudges3name"].ToString();
                matchEL.Linejudges4name = dt.Rows[0]["linejudges4name"].ToString();
                matchEL.Division = dt.Rows[0]["division"].ToString();
                matchEL.Matchdate = dt.Rows[0]["matchdate"].ToString();
                matchEL.Matchtime = dt.Rows[0]["matchtime"].ToString();
                matchEL.Teamaname = dt.Rows[0]["teamaname"].ToString();
                matchEL.Teamacoach = dt.Rows[0]["teamacoach"].ToString();
                matchEL.Teamaset1 = Convert.ToInt32(dt.Rows[0]["teamaset1"]);
                matchEL.Teamaset2 = Convert.ToInt32(dt.Rows[0]["teamaset2"]);
                matchEL.Teamaset3 = Convert.ToInt32(dt.Rows[0]["teamaset3"]);
                matchEL.Teamaset4 = Convert.ToInt32(dt.Rows[0]["teamaset4"]);
                matchEL.Teamaset5 = Convert.ToInt32(dt.Rows[0]["teamaset5"]);
                matchEL.Teamatimeout1 = Convert.ToInt32(dt.Rows[0]["teamatimeout1"]);
                matchEL.Teamatimeout2 = Convert.ToInt32(dt.Rows[0]["teamatimeout2"]);
                matchEL.Teamatimeout3 = Convert.ToInt32(dt.Rows[0]["teamatimeout3"]);
                matchEL.Teamatimeout4 = Convert.ToInt32(dt.Rows[0]["teamatimeout4"]);
                matchEL.Teamatimeout5 = Convert.ToInt32(dt.Rows[0]["teamatimeout5"]);
                matchEL.Teamawonsets = Convert.ToInt32(dt.Rows[0]["teamawonsets"]);
                matchEL.Teamaresult = dt.Rows[0]["teamaresult"].ToString();
                matchEL.Teambname = dt.Rows[0]["teambname"].ToString();
                matchEL.Teambcoach = dt.Rows[0]["teambcoach"].ToString();
                matchEL.Teambset1 = Convert.ToInt32(dt.Rows[0]["teambset1"]);
                matchEL.Teambset2 = Convert.ToInt32(dt.Rows[0]["teambset2"]);
                matchEL.Teambset3 = Convert.ToInt32(dt.Rows[0]["teambset3"]);
                matchEL.Teambset4 = Convert.ToInt32(dt.Rows[0]["teambset4"]);
                matchEL.Teambset5 = Convert.ToInt32(dt.Rows[0]["teambset5"]);
                matchEL.Teambtimeout1 = Convert.ToInt32(dt.Rows[0]["teambtimeout1"]);
                matchEL.Teambtimeout2 = Convert.ToInt32(dt.Rows[0]["teambtimeout2"]);
                matchEL.Teambtimeout3 = Convert.ToInt32(dt.Rows[0]["teambtimeout3"]);
                matchEL.Teambtimeout4 = Convert.ToInt32(dt.Rows[0]["teambtimeout4"]);
                matchEL.Teambtimeout5 = Convert.ToInt32(dt.Rows[0]["teambtimeout5"]);
                matchEL.Teambwonsets = Convert.ToInt32(dt.Rows[0]["teambwonsets"]);
                matchEL.Teambresult = dt.Rows[0]["teambresult"].ToString();
                matchEL.Currentset = Convert.ToInt32(dt.Rows[0]["currentset"]);
                matchEL.Bestof = Convert.ToInt32(dt.Rows[0]["bestof"]);


                return matchEL;
            }
            else
            {
                return null;
            }
        }


        public Boolean Delete(EL.Matches matchEL)
        {
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "delete from matches where matchid = @matchid";

                cmd.Parameters.AddWithValue("@matchid", matchEL.Matchid);

                return methods.executeNonQueryBool(cmd);
            }
        }

    }
}
