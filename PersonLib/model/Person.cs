using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLib.model
{
    public class Person
    {
        public String Name { get; set; }
        public String Address { get; set; }
        public int YearOfBirth { get; set; }

        public Person(string name, string address, int yearOfBirth)
        {
            Name = name;
            Address = address;
            YearOfBirth = yearOfBirth;
        }

        public Person():this("dummy","somewhere",1900)
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Address)}={Address}, {nameof(YearOfBirth)}={YearOfBirth.ToString()}}}";
        }
    }
}
