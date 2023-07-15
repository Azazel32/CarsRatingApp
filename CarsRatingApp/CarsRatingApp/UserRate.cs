namespace CarsRatingApp
{
    public class UserRate:UserRateBase
    {
        private List<float> Grades = new List<float>();
        private string Model;
        public UserRate(string name, string login, string password):base(name, login, password)
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
            if (grade >= 0 && grade <= 5)
            {
                this.Grades.Add(grade);
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }
        public override Statistics GetStatistics()
        {
            var stat = new Statistics();
            foreach (var grade in Grades)
            {
                stat.AddGradeToStat(grade);
            }
            return stat;
        }
        
        
            public override StatisticsInFile GetStatisticsFromFile()
            {

            var statistics = new StatisticsInFile();

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
