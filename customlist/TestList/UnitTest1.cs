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
        public void Add_TwoIntegers_ReturnsExpectedIntegers()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            //int firstExpectedValue = 0;
            int secondExpectedValue = 5;

            //Act
            list.Add(1); //[0]
            list.Add(2); //[1]
            list.Add(3); //[2]
            list.Add(4); //[3]
            int firstActualValue = list[4];
            list.Add(5); //[4]
            int secondActualValue = list[4];

            //Assert
            Assert.IsNull(firstActualValue);
            Assert.AreEqual(secondExpectedValue, secondActualValue);

        }

        [TestMethod]
        public void Remove_Integer_ReturnsExpectedInteger()
        {
            //Arange
            CustomList<int> list = new CustomList<int>();           
            int expectedResult = 8;

            //Act
            list.Add(2); //[0]
            list.Add(4); //[1]
            list.Add(6); //[2]
            list.Add(8); //[3]
            list.Add(10); //[4]
            list.Remove(8);
            int actualResult = list[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
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

        [TestMethod]
        public void Remove_Integer_ReturnsZero()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 0;

            //Act
            list.Add(50); //[0]
            list.Add(100); //[1]
            list.Add(150); //[2]
            list.Add(200); //[3]
            list.Add(250); //[4] 
            list.Remove(250);
            int actualResult = list[4];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Remove_Strings_ReturnsTwoDifferentStrings()
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
            Assert.IsNull(list[4]);

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


        public void ToString()
        {

            //Arange
            CustomList list = new CustomList();
            string actualResult;
            
            //Act
            actualResult = list[0].GetType();

            //Assert
            Assert.IsTrue(actualResult == string);

        }


    }
}
