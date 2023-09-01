namespace CarsRatingApp
{
    public class UserRateInMemory : UserRateBase
    {
        private List<float> grades = new List<float>();
        public UserRateInMemory(string name, string login, string password) : base(name, login, password)
        {
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
