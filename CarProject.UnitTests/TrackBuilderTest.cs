using CarProject.Logic;

namespace CarProject.UnitTests;

[TestClass]
public class TrackBuilderTest
{

  [TestMethod]
  public void ItShouldBuildAConnectedTrack_GivenSectionInformation()
  {
    (int, int)[ ] sectionInfos = { (10, 10) , (20, 20) , (30, 30) };

    TrackBuilder builder = new(sectionInfos);

    Section
      startSection = new(10 , 10),
      secondSection = new(20 , 20),
      thirdSection = new(30 , 30);

    Track manuallyBuiltTrack = new([ startSection , secondSection , thirdSection ]);
    manuallyBuiltTrack.StartSection!.AddAfterMe(secondSection);
    manuallyBuiltTrack.StartSection!.AddAfterMe(thirdSection);


    Assert.AreEqual(manuallyBuiltTrack.StartSection , builder.Track!.StartSection);
  }


}
