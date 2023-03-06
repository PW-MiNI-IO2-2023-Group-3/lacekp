using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Feature
    {
        public static string Method(string name)
        {
            if (name == "pawel")
            {
                return "ok";
            }

            return "bad";
        }
    }
}
