###### <p align="center"> Test-Driven Development (TDD) for Car and Track Project </p>
---
*This document contains an overview of the important tests for the Car, Section and Track classes as part of a Test-Driven Development (TDD) approach.*  
*Each test was written first and then the code was adjusted so that all tests were successful.*  

---
- # 1.) Important Additional Tests
  *To further validate the robustness and functionality of the program, the following tests can be implemented:*
  - ***Gear Transition Speed ​​Test***: Checks whether the speed resets or adjusts correctly when the gear changes from high to low.
  - ***Test for consistency of the dice value***: Checks whether rolling the dice always results in a number between 1 and 6 and that there are no exceptions or unexpected values.
  - ***Section Maximum Speed ​​Test***: Verify that the car's speed does not exceed the maximum speed of a section.
  - ***Test for gear change exception***: Checks whether ArgumentException is thrown correctly when invalid gear values ​​(e.g. above 6) are set.
  - ***Speed ​​test after multiple accelerations without changing gear***: Checks whether the speed behaves consistently when 'Accelerate' is called up several times.

---
- # 2.) Tests for the Car class
  - ***ItShouldHaveZeroSpeed_GivenGearIsZero***: Checks if Speed ​​is 0 when Gear is set to 0.
  - ***ItShouldHaveMaximumSpeed_GivenMaxGearAndDots***: Confirms the maximum speed calculation at maximum gear and dots.
  - ***ItShouldSetRollWasCalled_GivenAccelerateIsCalled***: Checks whether Roll() is triggered when Accelerate() is called.

---
- # 3.) Tests for the Section class
  - ***ItShouldSetMaxSpeedAndLength_GivenValidValues***: Ensures that MaxSpeed ​​and Length are set correctly.  
  - ***ItShouldThrowException_GivenNegativeMaxSpeed***: Checks whether negative MaxSpeed ​​values ​​throw an exception.
  - ***ItShouldThrowException_GivenNegativeLength***: Checks whether negative length values ​​throw an exception.

  - ## 3.1) Additional tests for Section
      - *Minimum Length Test* (***ItShouldThrowException_GivenLengthLessThanMinimum***): Tests whether an exception is thrown if Length is too low.
      - *Limit for MaxSpeed* ​​(***ItShouldThrowException_GivenMaxSpeedExceedsLimit***): Checks whether MaxSpeed ​​does not exceed the limit.

---
- # 4.) Tests for the Track class
  *If a track class contains multiple section instances, the following tests may be useful:*
  - *Total length test* (***ItShouldReturnTotalLength_GivenMultipleSections***): Checks whether GetTotalLength() calculates the correct total length of the sections.
  - *Maximum speed test* (***ItShouldReturnMaxSpeed_GivenMultipleSections***): Checks whether GetMaxSpeed() returns the highest allowed speed in the track.
  - *Empty Section List Test* (***ItShouldThrowException_GivenEmptySectionList***): Ensure an exception is thrown when track is created without sections.
  - *Test for null sections in the list* (***ItShouldThrowException_GivenNullSectionInList***): Checks whether no null objects are accepted as a section.

---
- # 5.) Summary
  *These tests cover the most important requirements and error conditions of the Car, Section and Track classes.*  
  *They validate the basic logic and robustness of the program and ensure that the application remains stable even with invalid inputs.*
