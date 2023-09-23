using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetClassesTwoApp
{
    internal class Person
    {
        public string Name { set; get; } = "";
        public int Age { set; get; }

        public Person() { }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Info
        {
            get
            {
                return $"{Name} {Age}";
            }
        }
    }

    class Employee : Person
    {
        public string Company { set; get; } = "";
        public Employee() { }
        public Employee(string company)
        {
            Company = company;
        }
        public Employee(string name, int age, string company)
            : base(name, age)
        {
            Company = company;
        }

        public new string Info
        {
            get
            {
                return $"{base.Info} {Company}";
            }
        }
    }

    class Client : Person
    {
        public string Bank { set; get; } = "";
        public Client() { }
        public Client(string bank)
        {
            Bank = bank;
        }
        public Client(string name, int age, string bank)
            : base(name, age)
        {
            Bank = bank;
        }

        public new string Info
        {
            get
            {
                return $"{base.Info} {Bank}";
            }
        }
    }
}
