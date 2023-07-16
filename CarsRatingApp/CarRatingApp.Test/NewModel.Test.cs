

using CarsRatingApp;

namespace CarRatingApp.Test
{
    public class NewModel
    {
        [Test]
        public void WhenModelAreHondaCivicTxt_ShouldReturnCorrect()
        {
           var user = new UserRate("Adam","login","pass");
            user.AddModel("1");
            var model=user.Model;
            Assert.AreEqual("Honda_Civic.txt", model);

        }

    }
}
