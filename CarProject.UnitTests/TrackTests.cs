using CarProject.Logic;

namespace CarProject.UnitTests;

[TestClass]
public class TrackTests
{

  [TestMethod]
  public void ItShouldCreateATrack_GivenAnyNumbersOfSections()
  {
    Section startSection = new(50 , 300);
    Section section = new(70 , 500);
    Section lastSection = new(60 , 200);

    List<Section> trackList = [ startSection , section , lastSection ];

    Track track = new(trackList);

    Assert.AreEqual(startSection , track.StartSection);
  }

}