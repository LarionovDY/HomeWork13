using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
{
    public sealed class MultiBuilding : Building        //класс описывающий многоэтажное здание 
    {

        private byte numberFloors;

        public byte NumberFloors
        {
            get { return numberFloors; }
            set
            {                             
                if (value <= 0)
                {
                    Console.WriteLine("Кол-во этажей не может быть нулевым, установлено минимальное значение по умолчанию (1 этаж)");
                    numberFloors = 1;
                }
                else if (value > 100)
                {
                    Console.WriteLine("Кол-во этажей слишком большое, установлено максимальное значение по умолчанию (100 этажей)");
                    numberFloors = 100;
                }
                else
                {
                    numberFloors = value;
                }
            }
        }
        public MultiBuilding(Address address, float length, float width, float height, byte numberFloors)
            : base(address, length, width, height)
        {
            NumberFloors = numberFloors;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"В здании {NumberFloors} этажа(ей)");
        }
    }
}
