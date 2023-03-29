using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClassLibrary1;

namespace prakt14_var19
{
    internal class Program
    {

        static public string word(string name)
        {
            for(int i=0;i<name.Length; i++)
            {
                if(!char.IsLetter(name[i]))
                {
                    return "введите буквы";
                }
            }
            return "";
        }
        static void Main(string[] args)
        {
           List<Dogs> spisok=new List<Dogs>();
            WorkingDogs wd = new WorkingDogs("вася пупкин", "аджилити", "бордюр колли", "7 марта", "санч", "вася пупкин");
            Console.WriteLine("выберите: \n1-Working Dogs\n2-Decorative Dogs");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("введите кол-во собак");
            int num = int.Parse(Console.ReadLine());
            while (true)
            {
                for (int j = 0; j < num; j++)
                {
                    if (n == 1)
                    {
                        Console.WriteLine("введите дрессировщика: ");
                        string trainer = Console.ReadLine();
                        Console.WriteLine("введите вид занятие: ");
                        string type_of_service = Console.ReadLine();
                        Console.WriteLine("порода собаки: ");
                        string breed = Console.ReadLine();
                        Console.WriteLine("дата рождения собаки: ");
                        string data = Console.ReadLine();
                        Console.WriteLine("кличка собаки: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("владелец собаки: ");
                        string owner = Console.ReadLine();
                        WorkingDogs wd1 = new WorkingDogs(trainer, type_of_service, breed, data, name, owner);
                        Console.WriteLine();
                        Console.WriteLine($"{trainer}\n{type_of_service}\n{breed}\n{data}\n{name}\n{owner}");

                    }
                }
                break;
            }
            
        }
    }
}
