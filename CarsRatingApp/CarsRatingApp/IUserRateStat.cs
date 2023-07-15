namespace CarsRatingApp
{
    public interface IUserRateStat
    {
        string Name { get; }
        string Login { get; }
        string Password { get; }
        void AddGrade(double grade);
        void AddGrade(string grade);
        void AddGrade(float grade);
        Statistics GetStatistics();

    }
}
