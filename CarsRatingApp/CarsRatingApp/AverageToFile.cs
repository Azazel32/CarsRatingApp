using System.IO;

namespace CarsRatingApp
{
    public class AverageToFIle
    {
        private string CarModel;
        public AverageToFIle(string model)
        {
            switch (model)
            {
                case "1":
                    {
                        this.CarModel = "Honda_Civic.txt";
                    }
                    break;
                case "2":
                    {
                        this.CarModel = "Toyota_Corolla.txt";
                    }
                    break;
                case "3":
                    {
                        this.CarModel = "Mitsubishi_Lancer.txt";
                    }
                    break;
            }
        }
        public void AddAvgToFile(float avg)
        {
            using (var writer = File.AppendText(this.CarModel))
            {
                writer.WriteLine(avg);
            }
        }
    }
}
