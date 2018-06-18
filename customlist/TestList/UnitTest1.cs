using System;
using System.Collections.Generic;
using customlist;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestList
{
    [TestClass]
    public class UnitTest1
    {
        int[] genericArray;

        [TestMethod]
        public void Add_Integer_ReturnsExpectedSmallInteger()
        {
            
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expectedValue = 10;

            //Act
            list.Add(10); //[0]
            list.Add(20); //[1]
            list.Add(30); //[2]
            list.Add(40); //[3]
            list.Add(50); //[4]
            int actualValue = list[0];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Add_Integer_ReturnsExpectedLargeInteger()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expectedValue = 5000;

            //Act
            list.Add(1000); //[0]
            list.Add(2000); //[1]
            list.Add(3000); //[2]
            list.Add(4000); //[3]
            list.Add(5000); //[4]
            int actualValue = list[4];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        [TestMethod]
        public void Add_String_ReturnsExpectedSmallString()
        {

            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expectedValue = "Hockey";

            //Act
            list.Add("Football"); //[0]
            list.Add("Soccer"); //[1]
            list.Add("Hockey"); //[2]
            list.Add("Baseball"); //[3]
            list.Add("Basketball"); //[4]
            int actualValue = list[2];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        [TestMethod]
        public void Add_String_ReturnsExpectedLargeString()
        {

            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expectedValue = "Lord of the Rings: Return of the King";

            //Act
            list.Add("Harry Potter and the Prizoner of Azkaban"); //[0]
            list.Add("The Dark Knight Rises"); //[1]
            list.Add("Captain America: Civil War"); //[2]
            list.Add("Lord of the Rings: Return of the King"); //[3]
            list.Add("Hector and the Search for Happiness"); //[4]

            string actualValue = list[3];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        [TestMethod]
        public void Add_TwoIntegers_ReturnsIncreasedCount() //count increases
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int firstExpectedValue = 4;
            int secondExpectedValue = 5;

            //Act
            list.Add(1); //[0]
            list.Add(2); //[1]
            list.Add(3); //[2]
            list.Add(4); //[3]
            int firstActualValue = list.Count();
            list.Add(5); //[4]
            int secondActualValue = list.Count();

            //Assert
            Assert.AreEqual(firstExpectedValue, firstActualValue);
            Assert.AreEqual(secondExpectedValue, secondActualValue);
        }

        [TestMethod]
        public void Remove_Integer_ReturnsExpectedInteger()
        {
            //Arange
            CustomList<int> list = new CustomList<int>();           
            int expectedResult = 10;

            //Act
            list.Add(2); //[0]
            list.Add(4); //[1]
            list.Add(6); //[2]
            list.Add(8); //[3]
            list.Add(10); //[4]
            list.Remove(8);
            int actualResult = list[3];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_Integer_ReturnsExpectedInteger()
        {
            //Arange
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 5;
            
            //Act
            list.Add(2); //[0]
            list.Add(4); //[1]
            list.Add(6); //[2]
            list.Add(8); //[3]
            list.Add(10); //[4]
            list.Remove(88);
            int actualResult = list.Count();

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
            
        }

        [TestMethod]
        public void Remove_String_ReturnsExpectedString()
        {

            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expectedResult = "Iced Tea";

            //Act
            list.Add("Ginger Ale"); //[0]
            list.Add("Gatorade"); //[1]
            list.Add("Lemonade"); //[2]
            list.Add("Iced Tea"); //[3]
            list.Add("Water"); //[4]
            list.Remove("Water");
            string actualResult = list[3];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]//////////////////////////
        public void Remove_Integer_ReturnsDecreasedCount()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int firstExpectedCount = 5;
            int secondExpectedCount = 4;

            //Act
            list.Add(50); //[0]
            list.Add(100); //[1]
            list.Add(150); //[2]
            list.Add(200); //[3]
            list.Add(250); //[4] 
            int firstActualCount = list.Count();
            list.Remove(250);
            int secondActualCount = list.Count();

            //Assert
            Assert.AreEqual(firstExpectedCount, firstActualCount);
            Assert.AreEqual(secondActualCount, secondExpectedCount);
        }

        [TestMethod]
        public void Remove_Strings_ReturnsNoStringChange()
        {

            //Arrange
            CustomList<string> list = new CustomList<string>();     
            string ExpectedResult = "Carlos Santana";

            //Act
            list.Add("Stevie Ray Vaughan"); //[0]
            list.Add("Jimi Hendrix"); //[1]
            list.Add("Angus Young"); //[2]
            list.Add("Eddie Van Halen"); //[3]           
            list.Add("Carlos Santana"); //[4]
            string ActualResult = list[4];
            list.Remove("Carlos Santana");          

            //Assert
            Assert.AreEqual(ActualResult, ExpectedResult);
        }

        [TestMethod]
        public void Remove_Integer_ReturnsNewInteger()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expectedValue = 10;

            //Act
            list.Add(5); //[0]
            list.Add(10); //[1]
            list.Add(15); //[2]
            list.Add(20); //[3]
            list.Add(25); //[4]
            list.Remove(5);
            int actualValue = list[0];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        [TestMethod]
        public void ToString_Integer_ReturnsString()
        {

            //Arange
            CustomList<int> list = new CustomLis<int>();
           
            //Act
            list.Add(10); //[0]
            list.Add(20); //[1]
            list.Add(30); //[2]
            list.Add(40); //[3]
            list.Add(50); //[4]
            int actualResult = list.ToString();

            //Assert
            Assert.IsInstanceOfType(actualResult, string);

        }

        [TestMethod]
        public void ToString_String_ReturnsNullString()
        {

            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expectedResult = null;

            //Act
            list.Add("Ears"); //[0]
            list.Add("Eyes"); //[1]
            list.Add("Nose"); //[2]
            list.Add("Hands"); //[3]
            list.Add("Hands"); //[4]
            list.ToString();
            string actualResult = list[1];

            //Assert
            Assert.AreEqual(actualResult, expectedResult);

        }

        [TestMethod]
        public void ToString_Boolean_ReturnsSpecificString()
        {

            //Arrange
            CustomList<bool> list = new CustomList<bool>();
            string expectedResult = "true";
            bool truth = true;
            bool fallacy = false;

            //Act
            list.Add(truth);
            list.Add(fallacy);
            list.ToString();
            string actualResult = List[0];

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void ToString_Integer_ReturnsMathSolution()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expectedResult = "34";

            //Act
            list.Add(14);
            list.Add(20);
            string actualResult = (list[0]) + (list[1]);
            actualResult = list.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToString_Integer_ReturnsNonInteger()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(25);
            list.Add(22);
            list.Add(20);
            list.Add(4);
            int actualResult = list.ToString();

            //Assert
            Assert.IsInstanceOfType(actualResult, string);
        }

    }
}
