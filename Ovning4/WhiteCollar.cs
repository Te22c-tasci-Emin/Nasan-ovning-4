using System;

namespace Ovning4;

public class WhiteCollar : Worker
{
    public WhiteCollar(string name, int age) : base(name, age) { }

    public void DrinkCoffee() => Console.WriteLine($"{name} is drinking coffee.");
    public void AttendMeeting() => Console.WriteLine($"{name} is attending a meeting.");
    public void DoSpreadsheets() => Console.WriteLine($"{name} is working on spreadsheets.");
}