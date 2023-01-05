using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClub.Common

{
    public static class Util
    {

        public static string Ellipses(int maxChars, string value)
        {
            return value.Length <= maxChars ? value : value.Substring(0, maxChars - 1) + "...";
        }

    }

}
