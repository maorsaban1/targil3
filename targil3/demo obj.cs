using System;
using System.Collections.Generic;
using System.Text;

namespace targil3
{
    public class DemoObject
    {
        public static void demo()
        {
            Console.WriteLine("objects Demo");
            Room r1 = new Room();
            Console.WriteLine("chir in color = " + r1.char1.color );
            r1.char1.color = "red";
            Console.WriteLine("chir in color = " + r1.char1.color);


        }
    }
    public class Chair
    {
        public string color = "blue";
        public int high = 40;
        public int lenge = 45;
        }
    public class Table
    {
        public string color = "red";
        public int high = 75;
        public int lenge = 80;
    }
    public class Room
    {
        public Chair char1 = new Chair();
        public Table table1 = new Table();
    }
}

