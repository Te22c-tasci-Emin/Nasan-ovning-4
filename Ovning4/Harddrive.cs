using System;

namespace Ovning4;

public class Harddrive : Hardware
{
    private int capacity;

    public Harddrive(string name, double price, int capacity) : base(name, price)
    {
        this.capacity = capacity;
    }

    public int GetCapacity() => capacity;
}




