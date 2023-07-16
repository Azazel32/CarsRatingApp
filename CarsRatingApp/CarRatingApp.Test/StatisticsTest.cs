

using CarsRatingApp;

namespace CarRatingApp.Test
{
    public class Tests
    {
        [Test]
        public void WhenSumIsCorrect_ShouldReturnCorrect()
        {
            var user = new UserRate("Adam","login","password");
            user.AddGrade(5);
            user.AddGrade("2");
            user.AddGrade("3,5");
            var stat = user.GetStatistics();

            Assert.AreEqual(10, 5, stat.Sum);
        }
        
        
        [Test]
        public void WhenStatAreCorrect_ShouldReturnCorrect() 
        {
            var user = new UserRate("Adam", "login", "password");
            user.AddGrade(5);
            user.AddGrade("2");
            user.AddGrade("3,5");
            var stat = user.GetStatistics();

            Assert.AreEqual(10, 5, stat.Sum);
            Assert.AreEqual(5, stat.Max);
            Assert.AreEqual(2,stat.Min);
            Assert.AreEqual(3.5, stat.Average);
        }
    }
}