using CarsRatingApp;
var UserInMemory = new UserRateInMemory("Adam", "AdamWu", "1234");
var UserInFile = new UserRateInFile("Adam", "AdamWu", "1234");
Console.WriteLine("Witaj w programie do oceniania samochodow!!");
Console.WriteLine("===========================================");
Console.WriteLine("Podaj Marke:");
Console.WriteLine("1.Honda civic. 2.Toyota corolla. 3.Mitsubishi lancer.");
string model = Console.ReadLine();
UserInFile.AddModel(model);
string input = "";
string[] properties = new string[3];
properties[0] = "Prowadzenie: ";
properties[1] = "Hamulce: ";
properties[2] = "Przyspieszenie: ";
void UserGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine($"Dodano nowa ocene");
}
UserInMemory.GradeAdded += UserGradeAdded;
UserInFile.GradeAdded += UserGradeAdded;
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
                            UserInMemory.AddGrade(input);
                            
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Statystki twoich ostanich ocen:");
                    var stat = UserInMemory.GetStatistics();
                    Console.WriteLine($"Max: {stat.Max}");
                    Console.WriteLine($"Min: {stat.Min}");
                    Console.WriteLine($"Average: {stat.Average:N2}");
                    Console.WriteLine($"Ocena {stat.AverageLetter}");
                }
                break;
            case "2":
                {
                    for (int i = 0; i <= 2; i++)
                    {
                        Console.WriteLine("Podaj ocene od 1 do 5 : ");
                        Console.Write(properties[i]);
                        input = Console.ReadLine();
                        try
                        {
                            UserInFile.AddGrade(input);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Ogolna ocena:");
                    var stat = UserInFile.GetStatistics();
                    Console.WriteLine($"Max: {stat.Max}");
                    Console.WriteLine($"Min: {stat.Min}");
                    Console.WriteLine($"Average: {stat.Average}");
                    Console.WriteLine($"Ocena {stat.AverageLetter}");
                }
                break;
            default:
                break;
        }
    }
}
Console.WriteLine("Do Widzenia");