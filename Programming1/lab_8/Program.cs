
Random rand = new Random();
int distance_between_diver_and_shark;
int distance_between_diver_and_shore;
int shark_location;
int diver_location;
int shore = 0;
shark_location = rand.Next(12,24);
diver_location = rand.Next(8,16);
bool SharkBitDiver = true;
bool DiverHitShore = true;
while ((SharkBitDiver = true) || (DiverHitShore = true))
{
    int shark_speed = rand.Next(1,4);
    int diver_speed = rand.Next(1,3);
    diver_location = (diver_location - diver_speed);
    shark_location = (shark_location - shark_speed);
    distance_between_diver_and_shore = (diver_location - 0);
    distance_between_diver_and_shark = (shark_location - diver_location);
    
    if (distance_between_diver_and_shark <= 0)
    {
        SharkBitDiver = !SharkBitDiver;
        Console.WriteLine("Shark Bit The Diver");
        Console.WriteLine(SharkBitDiver);
        break;
    }

    else (distance_between_diver_and_shore <= 0)
    {
        DiverHitShore = !DiverHitShore;
        Console.WriteLine("Diver Hit The Shore");
        Console.WriteLine(DiverHitShore);
        break;
    }
}



/*
//treats it like an and statemate
int distance_between_diver_and_shark;
int distance_between_diver_and_shore;
int shark_location;
int diver_location;
int shore = 0;
shark_location = rand.Next(12,24);
diver_location = rand.Next(8,16);
distance_between_diver_and_shore = (diver_location - shore);
distance_between_diver_and_shark = (shark_location - diver_location);
Console.WriteLine("TEST 123");
while ((distance_between_diver_and_shark == 0) || (distance_between_diver_and_shore == 0) || (distance_between_diver_and_shark > 0) || (distance_between_diver_and_shore > 0))
{
    int shark_speed = rand.Next(1,4);
    int diver_speed = rand.Next(1,3);
    diver_location = (diver_location - diver_speed);
    shark_location = (shark_location - shark_speed);
    distance_between_diver_and_shore = (diver_location - shore);
    distance_between_diver_and_shark = (shark_location - diver_location);
    Console.WriteLine($"distance_between_diver_and_shore:{distance_between_diver_and_shore}");
    Console.WriteLine($"distance_between_diver_and_shark:{distance_between_diver_and_shark}");
    Console.WriteLine($"DiverLocation:{diver_location}");
    Console.WriteLine($"sharkLocation:{shark_location}");
}
Console.WriteLine("FINISHED");
*/