using System;
using System.Collections.Generic;

namespace DllLibraryPodkolzina
{
    public class Apartament
    {
        //назначение и площадь комнат в квартире
        public string Number { get; set; }
        public string Owner { get; set; }
        public string Rooms { get; set; }
        public List<Room> Library = new List<Room>();
        public Apartament(string number, string owner, string rooms)
        {
            Number = number;
            Owner = owner;
            Rooms = rooms;
        }
        public void Show()
        {
            Console.WriteLine($"Квартира: номер = {Number}, владелец = {Owner}, список комнат = {Rooms}");
        }

    }
    public class Room
    {
        //класс команат
        public string Name { get; set; }
        public int Area { get; set; }
        public Room(string name, int area)
        {
            Name = name;
            Area = area;
        }
        public void Show()
        {
            Console.WriteLine($"Комната: назначение = {Name}, площадь = {Area}");
        }

    }
}
