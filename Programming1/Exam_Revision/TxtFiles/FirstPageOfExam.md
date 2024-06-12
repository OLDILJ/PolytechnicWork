






StreamReader sr = new StreamReader("file.txt");

for (int i = 0; i < players.Length; i++)
{
    players[i].fName = sr.ReadLine();
    players[i].lName = sr.ReadLine();
    players[i].age = sr.ReadLine();
}
sr.Close();