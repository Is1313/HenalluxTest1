﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Pupil : Person
    {
        List<Activity> listActivities;
        char[] tabEval;
        int grade;
        public int Grade { get; set; }
        public List<Activity> ListActivities { get; set; }
        public char[] TabEval { get; set; }
        public Pupil(string name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            ListActivities = new List<Activity>();
            TabEval = new char[10];
        }

        public Pupil(String name, int age) : this(name, age, 1) { }

        public void AddActivity(Activity act)
        {
            if (ListActivities.Count() <= Parameter.MAXACTIVITY)
                ListActivities.Add(act);
            else
                System.Console.Write("ERREUR : trop d'activité");
        }

        public override string ToString()
        {
            string ch = base.ToString();
            int cptActivities = ListActivities.Count();
            if (cptActivities == 0)
            {
                ch += " n'a pas encore choisi d'activité";
            }
            else
            {
                ch += " est inscrit aux activités suivantes : ";
                foreach (Activity activity in ListActivities)
                    ch += activity.ToString();
            }
            return ch;
        }

        public void AddEvaluation(String title = null, char evaluation = 'S')
        {
            foreach (Activity activity in ListActivities)
            {
                if (title.Equals(activity.Title))
                    TabEval[ListActivities.IndexOf(activity)] = evaluation;
            }
        }
    }
}
