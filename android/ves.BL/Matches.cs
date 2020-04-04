using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ves.BL
{
    public class Matches
    {
        DL.Matches matchDL = new DL.Matches();

        public DataTable List(string str)
        {
            return matchDL.List(str);
        }

        public long Insert(EL.Matches matchEL)
        {
            return matchDL.Insert(matchEL);
        }

        public Boolean Update(EL.Matches matchEL)
        {
            return matchDL.Update(matchEL);
        }

        public EL.Matches Select(EL.Matches matchEL)
        {
            return matchDL.Select(matchEL);
        }

        public Boolean Delete(EL.Matches matchEL)
        {
            return matchDL.Delete(matchEL);
        }
    }
}
