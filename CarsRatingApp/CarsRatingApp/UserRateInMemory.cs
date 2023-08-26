namespace CarsRatingApp
{
    public class UserRateInMemory : UserRateBase
    {
        private List<float> grades = new List<float>();
        public UserRateInMemory(string name, string login, string password) : base(name, login, password)
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
                this.grades.Add(grade);
                base.OnGradeAdded();
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public override Statistics GetStatistics()
        {
            var stat = new Statistics();
            foreach (var grade in grades)
            {
                stat.AddGradeToStat(grade);
            }
            return stat;
        }

    }
}
