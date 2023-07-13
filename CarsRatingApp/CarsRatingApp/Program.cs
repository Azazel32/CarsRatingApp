using CarsRatingApp;
using System.Reflection;
using System.Runtime.CompilerServices;

Console.WriteLine("Witaj w programie do oceniania samochodow!!");
Console.WriteLine("===========================================");
var user = new UserRate("Adam", "AdamWu", "1234");
while (true)
{
    Console.WriteLine("Zaczynamy? tak/nie");
    var start = Console.ReadLine();
    if (start == "tak")
    {
        Console.WriteLine("Co chcesz zrobic?");
        Console.WriteLine("1.Dodaj ocene");
        Console.WriteLine("2.Wyswielt oceny");
        Console.WriteLine("3.Wyswietl statystyki");
        Console.WriteLine("4.Wyjscie");
        var option = Console.ReadLine();
        Console.WriteLine("Podaj Marke:");
        Console.WriteLine("1.Honda civic. 2.Toyota corolla. 3.Mitsubishi lancer.");
        var model = Console.ReadLine();
        user.AddModel(model);
        switch (option)
        {
            case "1":
                {
                    while (true)
                    {
                        Console.WriteLine("Podaj ocene od 1 do 5 : ");
                        var input = Console.ReadLine();
                        if (input == "q")
                        {
                            break;
                        }
                        else
                        {
                            try
                            {
                                user.AddGrade(input);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }

                    }
                }
                break;
            case "2":
                {

                }
                break;
            case "3":
                {

                }
                break;
            default:
                break;
        }

    }
    else
    {
        break;
    }
}


Console.WriteLine("Do Widzenia");