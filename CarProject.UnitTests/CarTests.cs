using CarProject.Logic;

namespace CarProject.UnitTests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void ItShouldStandStill_GivenCreated()
        {
            // ARRANGE - Erstellen eines neuen Autos
            Car car = new Car();

            // ACT - Abfrage der Anfangsgeschwindigkeit des Autos
            int actualSpeed = car.Speed;

            // ASSERT - �berpr�fen, ob die Geschwindigkeit 0 ist
            Assert.AreEqual(0, actualSpeed); // Erwartung: Geschwindigkeit ist 0.
        }

        [TestMethod]
        public void ItShouldStore_GivenGearBetweenOneAndSix()
        {
            // ARRANGE - Erstellen eines neuen Autos
            Car car = new Car();

            // ACT - Setzen des Gangs auf einen g�ltigen Wert (z. B. 6)
            car.Gear = 6;

            // ASSERT - �berpr�fen, ob der Gang korrekt gespeichert wurde
            Assert.AreEqual(6, car.Gear); // Erwartung: Gang ist 6.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Gear should be between 0 and 6")]
        public void ItShouldThrowAnExpection_GivenGearOutsideRange()
        {
            // ARRANGE - Erstellen eines neuen Autos
            Car car = new Car();

            // ACT - Setzen eines ung�ltigen Gangwerts (z. B. 7)
            car.Gear = 7; // Erwartung: ArgumentException.

            // ASSERT - �berpr�fung erfolgt durch das ExpectedException-Attribut
        }

        [TestMethod]
        public void ItShouldHaveASpeedOfZero_GivenNoAcceleration()
        {
            // ARRANGE - Erstellen eines neuen Autos und Setzen des Gangs
            Car car = new Car();
            car.Gear = 3;

            // ACT - Keine Beschleunigung durchf�hren

            // ASSERT - �berpr�fen, ob die Geschwindigkeit 0 ist
            Assert.IsTrue(car.Speed == 0); // Erwartung: Geschwindigkeit ist 0.
        }

        [TestMethod]
        public void ItShouldHaveASpeedBetween30And180_GivenGear3AndAccelerated()
        {
            // ARRANGE - Erstellen eines neuen Autos und Setzen des Gangs
            Car car = new Car();
            car.Gear = 3;

            // ACT - Beschleunigung durchf�hren
            car.Accelerate();

            // ASSERT - �berpr�fen, ob die Geschwindigkeit im erwarteten Bereich liegt
            Assert.IsTrue(car.Speed >= 30 && car.Speed <= 180); // Erwartung: Geschwindigkeit zwischen 30 und 180.
        }

        class FakeDice : IDice
        {
            #region properties
            public int Dots { get; set; } // Festgelegter Wert f�r W�rfelaugen zur Kontrolle im Test
            public bool RollWasCalled { get; private set; } = false; // Flag, ob Roll() aufgerufen wurde
            #endregion properties

            #region methods
            public void Roll()
            {
                RollWasCalled = true; // Flag setzen, um zu pr�fen, ob Roll() aufgerufen wurde
            }
            #endregion methods
        }

        [TestMethod]
        public void ItShouldHaveASpeedOf60_GivenGear3AndDiceShowsTwoDots()
        {
            // ARRANGE - Erstellen eines Autos mit einem FakeDice und Setzen des Gangs
            FakeDice fakeDice = new FakeDice { Dots = 2 }; // Setzt die W�rfelaugen auf 2
            Car car = new Car(fakeDice);
            car.Gear = 3;

            // ACT - Beschleunigung durchf�hren
            car.Accelerate();

            // ASSERT - �berpr�fen, ob die Geschwindigkeit korrekt berechnet wurde (3 * 10 * 2 = 60)
            Assert.AreEqual(60, car.Speed); // Erwartung: Geschwindigkeit ist 60.
        }

        [TestMethod]
        public void ItShouldCallDiceRoll_GivenAccelerateIsCalled()
        {
            // ARRANGE - Erstellen eines Autos mit einem FakeDice
            FakeDice fakeDice = new FakeDice();
            Car car = new Car(fakeDice);

            // ACT - Beschleunigung durchf�hren
            car.Accelerate();

            // ASSERT - �berpr�fen, ob Roll() aufgerufen wurde
            Assert.IsTrue(fakeDice.RollWasCalled); // Erwartung: Roll() wurde aufgerufen.
        }


    }
}