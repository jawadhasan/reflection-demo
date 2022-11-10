
using ReflectionPoc.DemoApp.Vehicles;

namespace ReflectionPoc.DemoApp
{
    public static class ReportHelper
    {
        public static void Write(Vehicle vehicle)
        {
            
            Console.WriteLine($"{vehicle.Id} {vehicle.LicensePlate}");
        }
    }
}
