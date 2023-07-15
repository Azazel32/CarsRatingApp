
namespace CarsRatingApp
{
    public class Statistics
    {
        public  float Max { get; private set; }
        public  float Min { get; private set; }
        public float Average
        {
            get
            {
                return Sum / Counter;
            }
        }
        public  int Counter { get; private set; }
        public  float Sum { get; private set; }
        public Statistics()
        {
            this.Counter = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;

        }
        
        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 80:
                        return 'A';
                    case var average when average >= 60:
                        return 'B';
                    case var average when average >= 40:
                        return 'C';
                    case var average when average >= 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }
        

        
        public void AddGradeToStat(float grade)
        {
            this.Counter++;
            this.Sum += grade;
            this.Max = Math.Max(this.Max, grade);
            this.Min = Math.Min(this.Min, grade);
        }

    }
}
