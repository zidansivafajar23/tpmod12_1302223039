using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCariTandaBilangan
{
    public class TandaBilangan
    {
        public static string CariTandaBilangan(int a)
        {
            if (a < 0)
            {
                return "Negatif";
            }
            else if (a > 0)
            {
                return "Positif";
            }
            else
            {
                return "Nol";
            }
        }
    }
}
