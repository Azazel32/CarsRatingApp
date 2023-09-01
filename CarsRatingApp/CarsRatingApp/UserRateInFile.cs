namespace CarsRatingApp
{
    public class UserRateInFile : UserRateBase
    {
        private string model;
        public UserRateInFile(string name, string login, string password) : base(name, login, password)
        {
        }

        public void AddModel(string model)
        {
            switch (model)
            {
                case "1":
                    {
                        this.model = "Honda_Civic.txt";
                    }
                    break;
                case "2":
                    {
                        this.model = "Toyota_Corolla.txt";
                    }
                    break;
                case "3":
                    {
                        this.model = "Mitsubishi_Lancer.txt";
                    }
                    break;
            }
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(model))
                {
                    writer.WriteLine(grade);
                }
                OnGradeAdded();
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            if (File.Exists(model))
            {
                using (var reader = File.OpenText(model))
                {
                    var line = reader.ReadLine();
                    while ((line = reader.ReadLine()) != null)
                    {
                        var grade = float.Parse(line);
                        statistics.AddGradeToStat(grade);
                    }
                }
            }
            return statistics;
        }

    }
}

