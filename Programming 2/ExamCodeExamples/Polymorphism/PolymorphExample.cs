class BaseClass
{
    public virtual void WhatAmI()
    {
        Console.WriteLine("I Am The Base Class");
    }
}

class Derived1 : BaseClass
{
    public override void WhatAmI()
    {
        Console.WriteLine("I Am A Class Derived From Base");
    }
}

class Derived2 : BaseClass
{
    public override void WhatAmI()
    {
        Console.WriteLine("I Am Another Class Derived From Base");
    }
}

class MathClass
{
    public int AddingNumbers(int a, int b, int c)
    {
        return a + b + c;
    }
    public int AddingNumbers(int a, int b, int c, int d)
    {
        return a + b + c + d;
    }
}