using CarsRatingApp;
Console.WriteLine("Witaj w programie do oceniania samochodow!!");
Console.WriteLine("===========================================");
var user = new UserRate("Adam", "AdamWu", "1234");
Console.WriteLine("Podaj Marke:");
Console.WriteLine("1.Honda civic. 2.Toyota corolla. 3.Mitsubishi lancer.");
var model = Console.ReadLine();
var Model = new AverageToFIle(model);
user.AddModel(model);
string[] properties = new string[3];
properties[0] = "Prowadzenie: ";
properties[1] = "Hamulce: ";
properties[2] = "Przyspieszenie: ";
while (true)
{
        Console.WriteLine("Co chcesz zrobic?");
        Console.WriteLine("1.Dodaj ocene");
        Console.WriteLine("2.Wyswielt oceny");
        Console.WriteLine("3.Wyswietl statystyki");
        Console.WriteLine("4.Wyjscie");
        var option = Console.ReadLine();
    if (option == "4")
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
                        var input = Console.ReadLine();
                        try
                        {
                            user.AddGrade(input);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    var stat = user.GetStatistics();
                    var Average = stat.Average;
                    Model.AddAvgToFile(Average);
                    Console.WriteLine(stat.Min);
                    Console.WriteLine(stat.Max);
                    Console.WriteLine(stat.Average);


                }
                break;
            case "2":
                {
                    var stat= user.GetStatisticsFromFile();
                    Console.WriteLine(stat.Max);
                    Console.WriteLine(stat.Min);
                    Console.WriteLine(stat.Average);
                }
                break;
            default:

                break;
        }

    }  
}    
Console.WriteLine("Do Widzenia");