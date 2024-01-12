using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullName
{
  static  class  FullName
    {
        private static List<Person> _persons = new();
        public static void AddFullName(string firstName,string lastName)
        {
            var person = new Person(firstName, lastName);
            person.GetFullName();
            _persons.Add(person);
            
        }
        public static void ShowFullNames()
        {
            int i = 0;
            foreach (var person in _persons)
            {

                Console.Write(++i + ":");
                person.GetFullName();
            }
        }
    }
}
