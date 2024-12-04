using CarProject.Logic;

namespace CarProject.UnitTests;
  
[TestClass]
public class TrackBuilderTest
{

  [TestMethod]
  public void ItShouldBuildAConnectedTrack_GivenSectionInformation()
  {
    (int, int)[ ] sectionInfos = { (10, 10) , (20, 20) , (30, 30) };
    TrackBuilder builder = new TrackBuilder(sectionInfos);
    Assert.AreEqual(new Section(10 , 10) , builder.Track.Startsection);
  }


}
