using NetClassesTwoApp;
/*
Employee employee = new Employee("Bob", 25, "Yandex");

Person person = employee;
Console.WriteLine(employee.Info);
Console.WriteLine(person.Info);

object oemployee = employee;
object operson = person;

Console.WriteLine((person as Employee)?.Info);

object obj = new Employee("Tom", 32, "Ozon");
Employee empl = (Employee)obj;

Person perClient = new Client("Sam", 27, "SberBank");
Client? client = perClient as Client;

Console.WriteLine(employee is Employee);
Console.WriteLine(employee is Person);
Console.WriteLine(employee is Object);
Console.WriteLine(employee is Client);

PrintPerson(employee);
PrintPerson(client);

void PrintPerson(object person)
{
    if(person is Employee)
        Console.WriteLine("Employee!");
    if(person is Client)
        Console.WriteLine("Client!");
};
*/

Rectangle rectangle = new(5, 8);
Circle circle = new(8);

Console.WriteLine($"{rectangle.Area()} {rectangle.Perimetr()}");
Console.WriteLine($"{circle.Area()} {circle.Perimetr()}");

Shape shape = new Rectangle(5, 8);
Console.WriteLine($"{shape.Name} {shape.Area()} {shape.Perimetr()}");


Shape shape2 = new Rectangle(2, 3);

User<int, string> uInt = new();
User<string, double> uString = new();