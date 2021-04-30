using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string bufS;
            int bufInt;
            bool check;
            Human Tom = new Human();
            Console.WriteLine("Age: ");
            Tom.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: ");
            Tom.Name = Console.ReadLine();
            Parent TomP = new Parent();
            TomP.Questions();
            Console.WriteLine($"You need to protect your imagine child {TomP.Name} from computer games");
            Console.WriteLine("Enter new password");        
            do
            {
                bufS = Console.ReadLine();
                check = int.TryParse(bufS, out bufInt);
                if (check)
                {
                    check = false;
                }
                else
                {
                    check = true;
                }
            } while (check);
            IPass<int> password = new Security<int>(bufInt);
            Console.WriteLine("Enter new login");
            do
            {
                bufS = Console.ReadLine();
                check = int.TryParse(bufS, out bufInt);
            } while (check);
            IPass<string> Login = new Security<string>(bufS);
            Console.WriteLine("Do you want to see full info?\n1 - yes\nElse - no");
            int buf = Convert.ToInt32(Console.ReadLine());
            switch(buf)
            {
                case 1:
                    Tom.info();
                    TomP.Show();
                    Console.WriteLine($"Password : {password.Id}\nLogin: {Login.Id} ");break;
                default:break;
            }
        }
    }
}
