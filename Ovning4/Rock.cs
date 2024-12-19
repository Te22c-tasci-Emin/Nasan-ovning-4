using System;

namespace Ovning4;

public class Rock
{
    private double weight;

    public Rock(double weight)
    {
        this.weight = weight;
    }

    public double GetWeight()
    {
        return weight;
    }
}