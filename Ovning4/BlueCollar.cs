using System;

namespace Ovning4;

public class BlueCollar : Worker
{
    public BlueCollar(string name, int age) : base(name, age) { }

    public void Build() => Console.WriteLine($"{name} is building.");
    public void Repair() => Console.WriteLine($"{name} is repairing.");
    public void Destroy() => Console.WriteLine($"{name} is destroying.");
}