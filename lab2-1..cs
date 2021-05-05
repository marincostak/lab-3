using System;

namespace lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ведить число кольору");
            string S1 = Console.ReadLine();
            int x = int.Parse(S1);
           
            switch (x)
            { case 1:Console.WriteLine("Червоний");break;
                case 2:Console.WriteLine("Помаранчевий");break;
                case 3:Console.WriteLine("Жовтий");break;
                case 4:Console.WriteLine("Зелений");break;
                case 5:Console.WriteLine("Блакатний");break;
                case 6:Console.WriteLine("Синий");break;
                case 7:Console.WriteLine("Фіолетовий");break;
                default:Console.WriteLine("Пид таким числом немає кольору");break;

            }
           
        }
    }
}
