using System;
using System.Collections.Generic;
using System.Text;

namespace dashboard.BL
{
    public class Matches
    {
        DL.Matches matchDL = new DL.Matches();
        public Boolean Update(EL.Matches matchEL)
        {
            return matchDL.Update(matchEL);
        }

        public EL.Matches Select(EL.Matches matchEL)
        {
            return matchDL.Select(matchEL);
        }
    }
}
