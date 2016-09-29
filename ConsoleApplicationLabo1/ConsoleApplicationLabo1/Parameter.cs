using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public static class Parameter
    {
        private const int maxActivity = 10;
        private enum enumEval
        {
            R = 1,S,T
        }
        public static int MAXACTIVITY { get; set; }

        public static int ENUMEVAL { get; set; }
    }
}
