Random rand = new Random();
int distance_between_diver_and_shark;
int distance_between_diver_and_shore;
int shark_speed = rand.Next(0,4);
int diver_speed = rand.Next(0,2);
int shark_location;
int diver_location;
int shore = 0;
shark_location = rand.Next(12,24);
diver_location = rand.Next(8,16);
distance_between_diver_and_shore = diver_location - shore;
distance_between_diver_and_shark = shark_location - diver_location;
Console.WriteLine("TEST 123");
while ((distance_between_diver_and_shark != 0) || (distance_between_diver_and_shore != 0))
{
    shark_location = (shark_location - shark_speed);
    diver_location = (diver_location - diver_speed);
    Console.WriteLine($"the diver is {distance_between_diver_and_shore} from the shore");
    Console.WriteLine($"The shark is {distance_between_diver_and_shark} from the diver");
}
Console.WriteLine("FINISHED");