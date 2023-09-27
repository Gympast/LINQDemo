using System.ComponentModel;
using LINQDemo.Data;

var db = new DataSource();

double sum = 0;

foreach (var product in db.Stock)
{
    sum += product.Price;
}

Console.WriteLine(sum);

List<double> prices1 = new List<double>();
foreach (var product in db.Stock)
{
    prices1.Add(product.Price);
}

var prices = db.Stock.Select(p => p.Price);

foreach (var d in prices1)
{
    Console.WriteLine(d);
}

Console.WriteLine("---");

foreach (var price in prices)
{
    Console.WriteLine(price);
}

Console.WriteLine("-----");

Console.WriteLine(prices.Max());

Console.WriteLine("-----");


var names = db.People.Select((p => p.Name));

foreach (var name in names)
{
    Console.WriteLine(name);
}

var namesQ =
    from p in db.People
    select p.Name;


Console.WriteLine("-----");

var peopleStartingWithA = db.People.Where(p => p.Name[0] == 'R');

var peopleStartingWithB =
    from p in db.People
    where p.Name[0] == 'B'
    select p;

Console.WriteLine(peopleStartingWithA.Count());

foreach (var person in peopleStartingWithA)
{
    Console.WriteLine(person.Name);
}

Console.WriteLine("-----");
var peopleOverFifty = db.People.Where(p => p.Age > 50);

foreach (var person in peopleOverFifty)
{
    Console.WriteLine(person.Name);
    Console.WriteLine(person.Age);
    Console.WriteLine("____");
}

Console.WriteLine(peopleOverFifty.Min(a => a.Age));

Console.WriteLine("-----");

var peopleOrderedByAge = db.People.OrderBy(a => a.Age);

foreach (var person in peopleOrderedByAge)
{
    Console.WriteLine(person.Name);
    Console.WriteLine(person.Age);
    Console.WriteLine("____");
}