using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
{
    class Program
    {

        //Задан класс Building, который описывает здание.Класс содержит следующие элементы:
        //адрес здания, длина здания, ширина здания, высота здания.
        //В классе Building нужно реализовать следующие методы:
        //конструктор с 4 параметрами;
        //свойства get/set для доступа к полям класса;
        //метод Print(), который выводит информацию о здании.
        //Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность.В классе MultiBuilding реализовать следующие элементы:
        //конструктор с 5 параметрами – реализует вызов конструктора базового класса;
        //свойство get/set доступа к внутреннему полю класса;
        //метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
        //Класс MultiBuilding сделать таким, что не может быть унаследован.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите регион расположения здания:");
            string region = Console.ReadLine();
            Console.WriteLine("Название населенного пункта:");
            string city = Console.ReadLine();
            Console.WriteLine("Название улицы:");
            string street = Console.ReadLine();
            Console.WriteLine("Номер дома:");
            string house = Console.ReadLine();
            var address = new Address(region, city, street, house);
            float length = ReadFloatValue("Введите длину здания:");
            float width = ReadFloatValue("Введите ширину здания:");
            float height = ReadFloatValue("Введите высоту здания:");
            var building = new Building(address, length, width, height);
            building.Print();
            byte numberFloors = ReadByteValue("Введите количество этажей:");
            var building1 = new MultiBuilding(address, length, width, height, numberFloors);
            building1.Print();
            Console.ReadKey();
        }
        static float ReadFloatValue(string text)   //метод проверяющий корректность ввода данных
        {
            float value;
            while (true)
            {
                Console.WriteLine(text);
                if (Single.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Ввод некорректен");
                }
            }
        }
        static byte ReadByteValue(string text)   //метод проверяющий корректность ввода данных
        {
            byte value;
            while (true)
            {
                Console.WriteLine(text);
                if (Byte.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Ввод некорректен");
                }
            }
        }
    }    
}
