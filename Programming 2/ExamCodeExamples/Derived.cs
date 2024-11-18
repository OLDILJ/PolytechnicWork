public class DerivedExample : ModifierTest
{
    public void TestText()
    {
        Console.WriteLine("Attempting To Run Public Text");
        TextToScreen();
        Console.WriteLine("Attempting To Run Protected Text");
        ProtectedTextToScreen();
        try
        {
            Console.WriteLine("Attempting To Run Private Text");
            PrivateTextToScreen();

        }
        catch(Exception e)
        { 
            Console.WriteLine(e);
        }

    }
}