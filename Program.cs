using System;
using GenFu;
using System.Linq;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Everyone needs a little LINQ in their life!");

var people = A.ListOf<Person>(100);

var teamId = 1;
foreach (var team in people.Chunk(10))
{
    Console.WriteLine($"Team {teamId}");
    Console.WriteLine(string.Join(", ",team.Select(p => $"{p.FirstName} {p.LastName}")));
    System.Console.WriteLine("");
    System.Console.WriteLine("");

    var leader = team.MaxBy(people => people.Age);
    System.Console.WriteLine($"Leader: {leader.FirstName} Age:{leader.Age}");
    teamId++;
}

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int Age { get; set; }
}