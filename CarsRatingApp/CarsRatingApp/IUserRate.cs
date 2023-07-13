namespace CarsRatingApp
{
    public interface IUserRate
    {
        string Name { get; }
        string Login { get; }
        string Password { get; }

        void AddGrade(double grade);
        void AddGrade(string grade);
        void AddGrade(float grade);
        void AddModel(string model);
        Statistics GetStatistics();
    }
}
