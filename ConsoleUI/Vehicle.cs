using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; }
        public string Make { get; set; } = "Default make";
        public string Model { get; set; } = "Default Model";

        public abstract void DriveAbstract();//Stubbed out method

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"DriveVirtual Method from Abstract class Vehicle with default values of make:{Make}, model:{Model} and year:{Year}");
        }
    }
}
