using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Lab6
{
    class Parent : IParent
    {
        private int childs;
        private string name;
        public int Childs
        { get
            {
                return childs;
            }
            set
            {
                if (value < 0)
                    childs = 0;
                else
                    childs = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                        name = value;
            }
        }

        public void Show()
        {
            Console.WriteLine($"How many childs: {Childs}\nChilds Name: {Name}");
        }

        public void Questions()
        {
            Console.WriteLine("Сколько бы детей вы хотели");
            Childs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какое имя было бы у вашего первого ребенка");
            bool check;
            do
            {
                Name = Console.ReadLine();
                check = int.TryParse(name, out int buf);
            } while (check);
        }
    }
}
