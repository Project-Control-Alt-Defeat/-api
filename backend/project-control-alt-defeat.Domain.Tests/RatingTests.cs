using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace project_control_alt_defeat.Domain.Tests
{
    [TestClass]
    public class Rating
    {
        [TestMethod]
        public void Can_Create_New_Rating()
        {
            //Arrange
            var rating = new Rating(1, "Mike", "Great fit!");

            //Act - skip because there isn't action on constructor

            //Assert
            Assert.AreEqual(1, rating.Star);
            Assert.AreEqual("Mike", rating.UserName);
            Assert.AreEqual("Great fit!", rating.Review);
        }
    }
}
