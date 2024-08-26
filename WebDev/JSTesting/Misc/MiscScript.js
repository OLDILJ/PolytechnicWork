function TestFunction (Input)
{
    console.log ('TEST:', Input)
}

TestFunction("World");
TestFunction([]);
TestFunction([] + []);
TestFunction([] + {});
TestFunction({});
TestFunction({} + []);
TestFunction({} + {});
TestFunction(5);

TestFunction("World");
TestFunction([]);
TestFunction([] - []);
TestFunction([] - {});
TestFunction({});
TestFunction({} - []);
TestFunction({} - {});
TestFunction(5);
