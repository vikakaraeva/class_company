using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация работы класса:");
            string str = "Пример текстовой переменной";
            Company myCompany = new Company();
            myCompany.name = "Вика";
            myCompany.persons = 10;
            myCompany.money = 100000000;
            Console.WriteLine("имя:"+myCompany.name);
            Console.WriteLine("количество сотрудников:"+myCompany.persons);
            Console.WriteLine("зп:"+myCompany.money);
        }
    }
}
