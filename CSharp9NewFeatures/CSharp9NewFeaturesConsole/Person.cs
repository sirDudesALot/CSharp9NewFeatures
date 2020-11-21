using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9NewFeaturesConsole
{
    class Person
    {
        // Changed accessor of Id to init, which means the value can only be set once within a constructor
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public Person()
        {

        }
    }
}
