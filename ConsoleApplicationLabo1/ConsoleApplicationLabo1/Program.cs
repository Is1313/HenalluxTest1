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

            List<Pupil> listPupils = new List<Pupil>();
            {
                new Pupil("aaa", 10, 1);
                new Pupil("bbb", 20, 2);
                new Pupil("ccc", 30, 3);
                new Pupil("ddd", 40, 4);

            }

            List<Pupil> listPupilsDuplicated = new List<Pupil>();
            {
                new Pupil("aaa", 10, 1);
                new Pupil("bbb", 20, 2);
                new Pupil("ccc", 30, 3);
                new Pupil("ddd", 40, 4);

            }

            List<Person> listPersons = new List<Person>();
            {
                new Person("ppaaa", 10);
                new Person("ppbbb", 20);
                new Person("ppccc", 30);
                new Person("ppddd", 40);

            }

            var listFusion = listPersons.Union(listPupils);

            /*var pupilGrade1Plus6 = from pupil in listPupil
                                   where pupil.Grade == 1 && pupil.Age > 6
                                   select pupil;*/

            var pupilGrade1Plus6 = listPupil.Where(pupil => pupil.Grade == 1 && pupil.Age > 6)

            foreach (Pupil pupil in pupilGrade1Plus6)
                System.Console.Write(pupil);

            System.Console.Write(julien);
            System.Console.Read();



        }
    }
}
