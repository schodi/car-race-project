using CarProject.Logic;
namespace CarProject.UnitTests
{
    [TestClass]
    public class SectionTest
    {
        [TestMethod]
        public void ItShouldHaveALengthAndAMaxSpeed_GivenObjectCreated()
        {

            Section section = new Section(60, 400);

            Assert.AreEqual(60, section.MaxSpeed);
            Assert.AreEqual(400, section.Length);
        }
    }
}
