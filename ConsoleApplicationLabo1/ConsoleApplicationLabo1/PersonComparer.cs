using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            bool test = false;
            if (x == y)
                test = true;
            if (x.Age == y.Age && x.Name == y.Name)
                test = true;
            return test;
        }

        public int GetHashCode(Person obj)
        {
            return (int) Math.Pow(obj.Name.GetHashCode(), obj.Age);
        }
    }
}
