using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Person
    {
        private String name;
        private int age;

        public Person(String name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = (value > 0) ? value : 1;
            }
        }

        public override string ToString()
        {
            return Name + "âgée de " + Age + "ans";
        }

    }


}
