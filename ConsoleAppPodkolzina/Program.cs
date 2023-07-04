using System;
using System.Collections.Generic;
using DllLibraryPodkolzina;

namespace ConsoleAppPodkolzina
{
    internal class Program
    {
        internal class Rooms : IComparable<Rooms>
        {
            public string Name { get; set; }
            public int Area { get; set; }
            public Rooms(string name, int area)
            {
                Name = name;
                Area = area;
            }

            public override string ToString()
            {
                string s = $"Данные о комнате: \n" +
                           $"- Назначение: {Name} \n" +
                           $"- Площадь: {Area}";
                return s;
            }

            public int CompareTo(Rooms other)
            {
                if (this.Area > other.Area) return 1; //площадь одной комнаты больше площади другой
                if (this.Area < other.Area) return -1; //площадь одной комнаты меньше площади другой
                else return 0; //площади комнат равны
            }
        }

        static void Main(string[] args)
        {
            Apartament kv = new Apartament("16", "Кукушкин А.М.", "4");
            kv.Show();
            Console.WriteLine();
            Room r1 = new Room("Кухня", 15);
            kv.Library.Add(r1);
            Room r2 = new Room("Гостиная", 20);
            kv.Library.Add(r2);
            Room r3 = new Room("Спальня", 17);
            kv.Library.Add(r3);
            Room r4 = new Room("Санузел", 7);
            kv.Library.Add(r4);
            List<Rooms> col = new List<Rooms>();
            foreach (Room r in kv.Library)
            {
                r.Show();
                Rooms room = new Rooms(r.Name, r.Area);
                col.Add(room);
            }
            col.Sort();
            foreach (Rooms rooms in col)
            {
                Console.WriteLine();
                Console.WriteLine(rooms.ToString());
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
