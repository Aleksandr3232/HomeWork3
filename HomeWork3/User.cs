using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; }
        public Gender Gender { get; set; }
        public User()
        {
        }
        public User(int age)
        {
            Age = age;
        }
        public override string ToString()
        {
            return Age < 10 ? $"Hi, my name is {FirstName} and last name {LastName}." +
                              $"I am baby. I am {Gender}."
                            :
                              $"Hi, my name is {FirstName} and last name {LastName}." +
                              $"I am {Age} years old. I am {Gender}.";

        }
    }
}
