using System;

namespace Ovning4;

class Processor : Hardware
{
    private int cores;
    private double clockSpeed;

    public Processor(string name, double price, int cores, double clockSpeed) : base(name, price)
    {
        this.cores = cores;
        this.clockSpeed = clockSpeed;
    }

    public int GetCores() => cores;
    public double GetClockSpeed() => clockSpeed;
}
