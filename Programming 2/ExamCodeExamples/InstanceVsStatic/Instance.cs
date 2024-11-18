public class Instance
{
    private int InstanceNumber;

    public Instance (int InstanceNumber)
    {
        this.InstanceNumber = InstanceNumber;
    }
    public void WhatNumberAmI()
    {
        Console.WriteLine($"I am Instance # {InstanceNumber}");
    }
}