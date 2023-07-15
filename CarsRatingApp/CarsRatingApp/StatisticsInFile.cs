namespace CarsRatingApp
{
    public class StatisticsInFile
    {
        public float Max { get; private set; }
        public float Min { get; private set; }
        public float Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public int Count { get; private set; }
        public float Sum { get; private set; }
        
        public StatisticsInFile() 
        {
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
            this.Count = 0;
            this.Sum = 0;
        }
        public void AddGradeToStat(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Max = Math.Max(this.Max, grade);
            this.Min = Math.Min(this.Min, grade);
        } 
    }
}
