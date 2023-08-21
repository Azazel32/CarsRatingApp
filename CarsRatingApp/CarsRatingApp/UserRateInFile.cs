namespace CarsRatingApp
{
    public class UserRateInFile:UserRateBase
    { 
            private string Model;
            public UserRateInFile(string name, string login, string password) : base(name, login, password)
            {
            }
            public void AddModel(string model)
            {
                switch (model)
                {
                    case "1":
                        {
                            this.Model = "Honda_Civic.txt";
                        }
                        break;
                    case "2":
                        {
                            this.Model = "Toyota_Corolla.txt";
                        }
                        break;
                    case "3":
                        {
                            this.Model = "Mitsubishi_Lancer.txt";
                        }
                        break;
                }
            }
            public override void AddGrade(double grade)
            {
                if (float.MaxValue >= grade && float.MinValue <= grade)
                {
                    AddGrade((float)grade);
                }
                else
                {
                    throw new Exception("  Przekroczenie zasięgu FLOAT!");
                }
            }
            public override void AddGrade(string grade)
            {
                if (float.TryParse(grade, out float result))
                {
                    this.AddGrade(result);
                }
                else
                {
                    throw new Exception("String is not float");
                }
            }
            public override void AddGrade(float grade)
            {
                if (grade >= 0 && grade <= 100)
                {
                    using (var writer = File.AppendText(Model))
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
            if (File.Exists(Model))
            {
                using (var reader = File.OpenText(Model))
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

