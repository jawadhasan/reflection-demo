using System.Reflection;
using System.Threading.Channels;
using ReflectionPoc.DemoApp;
using ReflectionPoc.DemoApp.Vehicles;

//Demo2();
//Demo1();
//StartCode();
//Demo3();

Demo4();

void Demo4()
{
    var externalAssembly = Assembly.Load("System.Text.Json");
    var typesFromExternalAssembly = externalAssembly.GetTypes();
    var oneType = externalAssembly.GetType("System.Text.Json.JsonProperty");

    Console.WriteLine($"oneType: {oneType}");

    var modulesFromAssembly = externalAssembly.GetModules();
    var oneModule = externalAssembly.GetModule("System.Text.Json.dll");

    Console.WriteLine(modulesFromAssembly[0]);
    Console.WriteLine(oneModule);




}

void Demo3()
{
    var myAssembly = Assembly.GetExecutingAssembly();
    var typesFromAssembly = myAssembly.GetTypes();
    foreach (var type in typesFromAssembly)
    {
        Console.WriteLine(type.Name);
    }

    Console.WriteLine();

    //get a particular type from assembly
    //name must be fully-qualified-type-name
    var oneTypeFromAssembly = myAssembly.GetType("ReflectionPoc.DemoApp.Vehicles.Truck");
    Console.WriteLine(oneTypeFromAssembly);

}

void Demo2()
{
    var myVehicle = new Car("1", "car-1", "Tesla");
    var myVehicleType = myVehicle.GetType();
    Console.WriteLine(myVehicleType);

    var myVehicleType2 = typeof(Car);
    Console.WriteLine(myVehicleType2);
}

void Demo1()
{
    //string name = "jon";
    //var stringType = name.GetType();

    var stringType = typeof(string);
    Console.WriteLine(stringType);
}

void StartCode()
{


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

}