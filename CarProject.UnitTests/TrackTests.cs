using CarProject.Logic;

namespace CarProject.UnitTests
{
    [TestClass]
    public class TrackTests
    {
        private List<Section> CreateSampleSections() => new()
        {
            new Section(50, 300),
            new Section(70, 500),
            new Section(60, 200)
        };

        [TestMethod]
        public void StartSection_ShouldBeSaved_WhenTrackIsInitialized()
        {
            // Arrange
            List<Section> sections = CreateSampleSections();
            Section expectedStartSection = sections[0];

            // Act
            Track track = new(sections);

            // Assert
            Assert.AreEqual(expectedStartSection, track.StartSection);
        }

        [TestMethod]
        public void GetTotalLength_ShouldReturnCorrectSum_WhenMultipleSectionsExist()
        {
            // Arrange
            List<Section> sections = CreateSampleSections();
            Track track = new(sections);
            int expectedLength = 300 + 500 + 200;

            // Act
            int totalLength = track.GetTotalLenght;

            // Assert
            Assert.AreEqual(expectedLength, totalLength);
        }

        [TestMethod]
        public void GetMaxSpeed_ShouldReturnMaximumSpeed_WhenMultipleSectionsExist()
        {
            // Arrange
            List<Section> sections = CreateSampleSections();
            Track track = new(sections);
            int expectedMaxSpeed = 70;

            // Act
            int maxSpeed = track.GetMaxSpeed;

            // Assert
            Assert.AreEqual(expectedMaxSpeed, maxSpeed);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Sections cant be empty")]
        public void Constructor_ShouldThrowException_WhenSectionsListIsEmpty()
        {
            // Arrange
            List<Section> emptySections = new();

            // Act
            new Track(emptySections);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Sections cant be empty")]
        public void Constructor_ShouldThrowException_WhenSectionsListIsNull()
        {
            // Arrange
            List<Section>? nullSections = null;

            // Act
            new Track(nullSections);
        }

        [TestMethod]
        public void LastSection_ShouldConnectToStartSection_WhenTrackIsLooped()
        {
            // Arrange
            List<Section> sections = CreateSampleSections();
            Section expectedStartSection = sections[0];
            Section lastSection = sections[^1];

            // Act
            Track track = new(sections, trackShallLoop: true);

            // Assert
            Assert.AreEqual(expectedStartSection, lastSection.NextSection);
        }
    }
}
