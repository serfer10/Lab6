using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Human : IParametrs
    {
        private string name;
        private int age;
        public string Name { get { return name; }  set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public void info()
        {
            Console.WriteLine($"name: {name}\nage:{age}");
        }
    }
}
