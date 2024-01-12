using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullName
{
    class Person
    {
        private string _FirstName;
        private string _LastName;
        public Person(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Null value is not valid");
                }
                _FirstName = value;

            }
        }
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Null value is not valid");
                }
                _LastName = value;

            }
        }
        public void GetFullName()
        {
            Console.WriteLine(FirstName+" "+ LastName);
        }
    }
}
