
namespace Exercise1Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            newCar.Make = "Tesla";
            newCar.Model = "Hafiz";
            newCar.Year = 2024;

            Console.WriteLine($"{newCar.Make} {newCar.Model} {newCar.Year}");
        }
    }
}