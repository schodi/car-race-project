using CarProject.Logic;

namespace CarProject.UnitTests;

[TestClass]
public class TrackBuilderTest
{

  [TestMethod]
  public void ItShouldBuildAConnectedTrack_GivenSectionInformation()
  {
    (int, int)[ ] sectionInfos = [ (10, 10) , (20, 20) , (30, 30) ];

    TrackBuilder builder = new(sectionInfos);

    Section
      startSection = new(10 , 10),
      secondSection = new(20 , 20),
      thirdSection = new(30 , 30);

    startSection.AddAfterMe(secondSection);
    secondSection.AddAfterMe(thirdSection);
    Track manuallyBuiltTrack = new([ startSection , secondSection , thirdSection ]);

    Assert.AreEqual(10 , manuallyBuiltTrack.StartSection!.Length);
    Assert.AreEqual(10 , manuallyBuiltTrack.StartSection.MaxSpeed);
    Assert.AreEqual(startSection , manuallyBuiltTrack.StartSection);
    Assert.AreEqual(secondSection , manuallyBuiltTrack.StartSection.NextSection);

    Assert.AreEqual(10 , builder.RaceTrack!.StartSection!.Length);
    Assert.AreEqual(10 , builder.RaceTrack.StartSection.MaxSpeed);

    Assert.AreEqual(manuallyBuiltTrack.StartSection.Length , builder.RaceTrack.StartSection.Length);
    Assert.AreEqual(manuallyBuiltTrack.StartSection.MaxSpeed , builder.RaceTrack.StartSection.MaxSpeed);
    Assert.AreEqual(manuallyBuiltTrack.StartSection.NextSection!.Length , builder.RaceTrack.StartSection.NextSection!.Length);
    Assert.AreEqual(manuallyBuiltTrack.StartSection.NextSection.MaxSpeed , builder.RaceTrack.StartSection.NextSection.MaxSpeed);
    Assert.AreEqual(manuallyBuiltTrack.StartSection.NextSection.NextSection!.Length ,   builder.RaceTrack.StartSection.NextSection.NextSection!.Length);
    Assert.AreEqual(manuallyBuiltTrack.StartSection.NextSection.NextSection.MaxSpeed , builder.RaceTrack.StartSection.NextSection.NextSection.MaxSpeed);
  }


}
