using System;

namespace Ovning4;

public class Worker
{
    protected string name;
    protected int age;
    protected double wage;

    public Worker(string name, int age)
    {
        this.name = name;
        this.age = age;
        this.wage = 0; // Startvärde
    }

    public void SetWage(double wage)
    {
        this.wage = wage;
    }

    public string GetName() => name;
    public int GetAge() => age;
    public double GetWage() => wage;
}

