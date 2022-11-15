
using ReflectionPoc.DemoApp.Vehicles;

namespace ReflectionPoc.DemoApp
{
    public static class ReportHelper
    {
        public static void Write(Vehicle vehicle)
        {
            
            Console.WriteLine($"{vehicle.Id} {vehicle.LicensePlate}");

        }

        public static void WriteV2(Vehicle vehicle)
        {

            Console.WriteLine($"{vehicle.Id} {vehicle.LicensePlate}");
            Console.WriteLine();

            var propInfos = ReflectionHelper.GetPropertyValueList(vehicle);
            Console.WriteLine(propInfos);
        }

       
    }
}
