BaseClass OriginalClass = new BaseClass();
BaseClass Derived1 = new Derived1();
BaseClass Derived2 = new Derived2();
MathClass MathTime = new MathClass();

OriginalClass.WhatAmI();
Derived1.WhatAmI();
Derived2.WhatAmI();
Console.WriteLine(MathTime.AddingNumbers(1,2,3));
Console.WriteLine(MathTime.AddingNumbers(1,2,3,6));
