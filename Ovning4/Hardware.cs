using System;

namespace Ovning4;

public class Hardware
{
    private string name;
    private double price;

    public Hardware(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    public string GetName() => name;
    public double GetPrice() => price;
}
