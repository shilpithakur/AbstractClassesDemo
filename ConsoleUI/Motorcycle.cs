using System;
namespace ConsoleUI
{
    public class Motorcycle:Vehicle
    {
        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine($"DriveAbstract: This is a {Make} {Model} from {Year}");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"DriveVirtual: This is a {Make} {Model} from {Year}");
        }
    }
}
