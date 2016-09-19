using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Program
    {
        private static List<Pupil> listPupil;
        static void Main(string[] args)
        {
            
            Pupil julien = new Pupil("julien", 27);
            Activity act1 = new Activity("chasse", true);
            Activity act2 = new Activity("pêche", false);

            julien.AddActivity(act1);
            julien.AddActivity(act2);

            julien.AddEvaluation("peche");
            julien.AddEvaluation(evaluation: 'T', title: "chasse");

            System.Console.Write(julien);
            System.Console.Read();



        }
    }
}
