####### <p align="center"> CarProject - Documentation </p>

---
- # 1.) Overview  
  The 'CarProject' project simulates a car model that takes speed and gear into account and includes random components in acceleration via a cube interface.  
  The logic includes several classes such as 'Car', 'DefaultDice', and 'Section' as well as associated unit tests that check the behavior of the car.  

---
- # 2.) Explanation of the Classes and Interfaces  

- ## 2.1) Class Car  
  The 'Car' class represents the car with the following main characteristics:  
  - _gear: A private field that stores the current gear of the car.
    > Default is 0.  
  - _speed: A private field that stores the speed of the car.
    > Default is 0.  
  - _dice: A dice object (of type 'IDice') that provides random values ​​to influence speed.  
  
  - The 'Accelerate' method rolls a dice and calculates the speed based on the current gear and the eyes rolled.
  - The Gear property has validation that ensures that only values ​​between 0 and 6 are accepted.	

- ## 2.2) Interface IDice  
  The 'IDice' interface defines the structure of a cube used in this project.  
  It contains the properties and methods necessary for the cube implementations:  
  - Dots: A property that represents the number of dots rolled.  
  - Roll(): A method that rolls the dice and sets a new random number.  

- ## 2.3) Class DefaultDice  
  The 'DefaultDice' class implements the 'IDice' interface and uses a random generator to roll a number between 1 and 6.  
  The result is stored in the 'Dots' property.  
  This allows you to control the dice roll and realistically simulate the behavior of the car.  

- ## 2.4) Class Section  
  The 'Section' class represents a road section that is described by the maximum permitted speed ('MaxSpeed') and the length ('Length') of the section.  
  This allows a realistic simulation of various road conditions and restrictions.  

---
- # 3.) Unit testing  
  Unit tests validate the behavior of classes and methods and ensure that requirements are met.  
  The main tests are as follows:  

- ## 3.1) Car Tests  
  Check the tests for the 'Car' class:  
  - Initial values ​​such as speed and gear when creating a car.
  - Validation of gears between 0 and 6 as well as exception handling for invalid values.
  - The acceleration logic by using a FakeDice to test the speed based on a known value.

- ## 3.2) SectionTest  
  This test ensures that the Section class correctly stores and initializes the MaxSpeed ​​and Length attributes.

---
- # 4.) Test expansion options   
  There are several ways to further extend the tests and examine additional scenarios:  
  - Negative tests for 'Accelerate' to catch invalid conditions such as negative speed.  
  - Compliance with MaxSpeed ​​constraints in the 'Section' class to test whether the auto speed respects the section boundaries.  
  - Check error messages for invalid gear values ​​to ensure that the expected exceptions are thrown correctly.  



----
<!--
Schritt / Aspekt
Mit DefaultDice
Mit FakeDice
Erstellen des Car-Objekts
DefaultDice wird automatisch verwendet
FakeDice wird explizit übergeben
Aufruf von Roll()
Generiert eine zufällige Zahl für Dots
Setzt nur RollWasCalled auf true
Berechnung von Speed
Geschwindigkeit variiert, basierend auf Dots
Geschwindigkeit ist konstant (z. B. Dots = 2)
Ergebnisse im Test
Geschwindigkeit hängt von zufälligem Dots ab
Geschwindigkeit ist vorhersehbar, RollWasCalled überprüfbar
Dots
Zufälliger Wert zwischen 1 und 6
Fester Wert für kontrollierte Tests
Roll() Verhalten
Generiert und setzt zufälligen Dots-Wert
Setzt RollWasCalled auf true, Dots bleibt unverändert --> 




