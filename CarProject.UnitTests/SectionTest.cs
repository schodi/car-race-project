using CarProject.Logic;
namespace CarProject.UnitTests
{
    [TestClass]
    public class SectionTest
    {
        [TestMethod]
        public void ItShouldHaveALengthAndAMaxSpeed_GivenObjectCreated()
        {
            var someSpeed = 60;
            var someLength = 400;
            Section section = new Section(someSpeed, someLength);

            Assert.AreEqual(someSpeed, section.MaxSpeed);
            Assert.AreEqual(someLength, section.Length);
        }
    }
}
