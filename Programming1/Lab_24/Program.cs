// See https://aka.ms/new-console-template for more information
int position = 0;
Random rand = new Random();
List<int> numbers = new List<int>();
Console.WriteLine("Welcome to Gnome Sort");
Console.WriteLine("Would You Like To Insert A Random Integer Array?");
Console.WriteLine("Or Would You Like To Provide Your Own?");
Console.WriteLine("1. Random Int Array");
Console.WriteLine("2. Provide Array Manually");
string UserResponse = ("");
UserResponse = Console.ReadLine();
switch(UserResponse)
{
    case "1" or "1.":
        Console.WriteLine("Random Int Array Selected");
        Console.WriteLine(numbers.Count);
        Console.WriteLine("How Large Do You Want The Array To Be?");
        int UserResponse2 = 0;
        UserResponse2 = Convert.ToInt32(Console.ReadLine());
        while (numbers.Count < UserResponse2)
        {
            numbers.Add(rand.Next(0,9)); 
            UserResponse2 = UserResponse2 + 1;
            Console.WriteLine("One Slot Filled");
            Console.WriteLine(UserResponse2);
            Console.WriteLine(numbers.Count);
        }
        break;
    default:
        Console.WriteLine("DefaultTest");
        break;

}






GnomeSort(numbers);
void GnomeSort (List<int> numbers)
{
    while (position < numbers.Count)
    {
        int posbackone = (position - 1);
        if (position == 0 || numbers[position] >= numbers[posbackone])
        {
            Console.WriteLine("Up, One Position");
            position = (position + 1);
        }
        else
        {
            Console.WriteLine("Swap Position, Back One");
            (numbers[position], numbers[posbackone]) = (numbers[posbackone], numbers[position]);
            position = (position - 1);
        }
    }
}