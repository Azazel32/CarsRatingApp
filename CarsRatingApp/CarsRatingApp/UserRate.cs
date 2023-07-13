namespace CarsRatingApp
{
    public class UserRate : UserRateBase
    {
        private string CarModelFile;
        public UserRate(string name, string login, string password) : base(name, login, password)
        {
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
                using (var writer = File.AppendText(CarModelFile))
                {
                    writer.WriteLine(grade);
                }

            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public override void AddModel(string model)
        {

            switch (model)
            {
                case "1":
                    {
                        CarModelFile = "Honda_Civic.txt";
                    }
                    break;
                case "2":
                    {
                        CarModelFile = "Honda_Civic.txt";
                    }
                    break;
                case "3":
                    {
                        CarModelFile = "Honda_Civic.txt";
                    }
                    break;
            }
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
