using CarsRatingApp;
Console.WriteLine("Witaj w programie do oceniania samochodow!!");
Console.WriteLine("===========================================");
var user = new UserRate("Adam", "AdamWu", "1234");
Console.WriteLine("Podaj Marke:");
Console.WriteLine("1.Honda civic. 2.Toyota corolla. 3.Mitsubishi lancer.");
var model = Console.ReadLine();
var Model = new AverageToFIle(model);
user.AddModel(model);
string input = "";
string[] properties = new string[3];
properties[0] = "Prowadzenie: ";
properties[1] = "Hamulce: ";
properties[2] = "Przyspieszenie: ";
void UserGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nowa ocene:");
}
user.GradeAdded += UserGradeAdded;
void UserShowStat(object sender, EventArgs args)
{
    Console.WriteLine($"Statystki: {input}");
}
user.ShowStat += UserShowStat;
while (true)
{
    Console.WriteLine("Co chcesz zrobic?");
    Console.WriteLine("1.Dodaj ocene");
    Console.WriteLine("2.Wyswietl ogolne statystyki");
    Console.WriteLine("3.Wyjscie");
    var option = Console.ReadLine();
    if (option == "3")
    {
        break;
    }
    else
    {
        switch (option)
        {
            case "1":
                {
                    for (int i = 0; i <= 2; i++)
                    {
                        Console.WriteLine("Podaj ocene od 1 do 5 : ");
                        Console.Write(properties[i]);
                        input = Console.ReadLine();
                        try
                        {
                            user.AddGrade(input);

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Statystki twoich ostanich ocen:");
                    var stat = user.GetStatistics();
                    var Average = Math.Round(stat.Average);
                    Model.AddAvgToFile((float)Average);
                    Console.WriteLine(stat.Min);
                    Console.WriteLine(stat.Max);
                    Console.WriteLine(stat.Average);


                }
                break;
            case "2":
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ogolna ocena:");
                    var stat = user.GetStatisticsFromFile();
                    Console.WriteLine($"Max: {stat.Max}");
                    Console.WriteLine($"Min: {stat.Min}");
                    Console.WriteLine($"Avergae: {stat.Average}");
                }
                break;
            default:

                break;
        }

    }
}
Console.WriteLine("Do Widzenia");