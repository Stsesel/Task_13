using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Building building = new Building("Владивосток, Ленина, 10", 40, 14, 60);
            Console.WriteLine("Введите адрес в порядке через запятую: город, улица, номер дома");
            string adress;
            adress =Console.ReadLine();
            Console.WriteLine("Введите длину здания");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину здания");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту здания");
            double hight = Convert.ToDouble(Console.ReadLine());

            Building building = new Building(adress, length, width, hight);





            Console.WriteLine(building.Print());
            Console.WriteLine();
            MultiBuilding multiBuilding = new MultiBuilding("Архангельск, Пушкина, 12", 20, 13, 30, 10);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }   
    }
}
