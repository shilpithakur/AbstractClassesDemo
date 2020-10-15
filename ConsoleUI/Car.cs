using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"DriveAbstract: This is a {Make} {Model} from {Year}");
           
        }

        public Car()
        {
            
        }
       
    }
}
