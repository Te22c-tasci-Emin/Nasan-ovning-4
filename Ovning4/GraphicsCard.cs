using System;

namespace Ovning4;

public class GraphicsCard : Hardware
{
    private int memory;

    public GraphicsCard(string name, double price, int memory) : base(name, price)
    {
        this.memory = memory;
    }

    public int GetMemory() => memory;
}



