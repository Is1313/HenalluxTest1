using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pupil> listPupil =new List<Pupil>();
            Pupil loic = new Pupil("loic", 47);
            Pupil julien = new Pupil("julien", 27);
            Activity act1 = new Activity("chasse", true);
            Activity act2 = new Activity("pêche", false);

            julien.AddActivity(act1);
            julien.AddActivity(act2);

            julien.AddEvaluation("peche");
            julien.AddEvaluation(evaluation: 'T', title: "chasse");

            listPupil.Add(julien);
            listPupil.Add(loic);

            var pupilGrade1Plus6 = from pupil in listPupil
                                   where pupil.Grade == 1 && pupil.Age > 6
                                   select pupil;

            foreach (Pupil pupil in pupilGrade1Plus6)
                System.Console.Write(pupil);

            System.Console.Write(julien);
            System.Console.Read();



        }
    }
}
