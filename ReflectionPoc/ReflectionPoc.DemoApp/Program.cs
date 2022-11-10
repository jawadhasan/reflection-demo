
using ReflectionPoc.DemoApp;
using ReflectionPoc.DemoApp.Vehicles;

Console.WriteLine("************");
var car = new Car("1", "car-1", "Tesla");
var truck = new Truck("2", "truck-1", 4);
var flyingCar = new FlyingCar("3", "fly-1", 2000);

var vehicles = new List<Vehicle> {
    car,truck,flyingCar
};

foreach (var vehicle in vehicles)
{
    ReportHelper.Write(vehicle);
}




Console.ReadLine();