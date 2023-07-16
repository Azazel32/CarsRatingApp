
using CarsRatingApp;

namespace CarRatingApp.Test
{
    public class AverageLetter
    {
        public void ExpextedAverageLetter_SchouldIsA()
        {
            var user = new UserRate("Adam", "login", "password");
            user.AddGrade(5);
            user.AddGrade("5");
            user.AddGrade("5");
            var statistics = user.GetStatistics();

            Assert.AreEqual('A', statistics.AverageLetter);
        }
        [Test]
        public void ExpextedAverageLetter_SchouldIsB()
        {
            var user = new UserRate("Adam", "login", "password");
            user.AddGrade(4);
            user.AddGrade("4");
            user.AddGrade("4");
            var statistics = user.GetStatistics();

            Assert.AreEqual('B', statistics.AverageLetter);
        }
        [Test]
        public void ExpextedAverageLetter_SchouldIsC()
        {
            var user = new UserRate("Adam", "login", "password");
            user.AddGrade(3);
            user.AddGrade("4");
            user.AddGrade("2");
            var statistics = user.GetStatistics();

            Assert.AreEqual('C', statistics.AverageLetter);
        }
        [Test]
        public void ExpextedAverageLetter_SchouldIsD()
        {
            var user = new UserRate("Adam", "login", "password");
            user.AddGrade(3);
            user.AddGrade("2");
            user.AddGrade("1");
            var statistics = user.GetStatistics();

            Assert.AreEqual('D', statistics.AverageLetter);
        }
        [Test]
        public void ExpextedAverageLetter_SchouldIsE()
        {
            var user = new UserRate("Adam", "login", "password");
            user.AddGrade(1);
            user.AddGrade("1");
            user.AddGrade("1,5");
            var statistics = user.GetStatistics();

            Assert.AreEqual('E', statistics.AverageLetter);
        }
    }
}
