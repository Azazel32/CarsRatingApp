namespace CarsRatingApp
{
    public abstract class UserRateBase : IUserRateStat
    {
        public UserRateBase(string name, string login, string password)
        {
            this.Name = name;
            this.Login = login;
            this.Password = password;
        }
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public event GradeAddedDelegate GradeAdded;
        public void OnGradeAdded()
        {
            if (GradeAdded != null)
                GradeAdded(this, new EventArgs());
        }

        public string Name { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public void AddGrade(double grade)
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
        public void AddGrade(string grade)
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
        
        public abstract void AddGrade(float grade);
        public abstract Statistics GetStatistics();
    }
}
