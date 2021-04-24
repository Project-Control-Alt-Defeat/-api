using Microsoft.VisualStudio.TestTools.UnitTesting;
using project.control.alt.defeat.Domain.Catalog;

namespace project_control_alt_defeat.Domain.Tests
{
    [TestClass]
    public class UnitTest1
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