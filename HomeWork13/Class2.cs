using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
{
    public class Building       //класс описывающий одноэтажное здание
    {
        public string Address { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public Building(Address address, float length, float width, float height)
        {
            Address = address.SetAddress();
            Length = length;
            Width = width;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine($"Адрес здания: {Address}\nДлина здания : {Length}\nШирина здания: {Width}\nВысота здания: {Height}");
        }
    }
}
