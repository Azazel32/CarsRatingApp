namespace CarsRatingApp
{
    public abstract class UserRateBase : IUserRateStat
    {
        public UserRateBase(string name,string login, string password) 
        {
            this.Name = name;
            this.Login = login;
            this.Password = password;
        }
        public string Name { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(string grade);
        public abstract void AddGrade(float grade);
        public abstract Statistics GetStatistics();
        public abstract StatisticsInFile GetStatisticsFromFile();
    }
}
