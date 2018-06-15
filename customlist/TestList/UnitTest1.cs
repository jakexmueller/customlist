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
            CustomList<string> list = new CustomList<string>;
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
            CustomList<string> list = new CustomList<string>;
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
            CustomList<int> list = new CustomList<int>;
            int expectedValues = (3, 4);

            //Act
            list.Add(1, 2); //[0]
            list.Add(3, 4); //[1]
            list.Add(5, 6); //[2]
            list.Add(7, 8); //[3]
            list.Add(9, 10); //[4]
            int actualValues = list[1];

            //Assert
            Assert.AreEqual(expectedValues, actualValues);

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
            list.Remove[4];
            int actualResult = list[3];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_String_ReturnsExpectedString()
        {

            //Arrange
            CustomList<string> list = new CustomList<string>;
            string expectedResult = "Gatorade";

            //Act
            list.Add("Ginger Ale"); //[0]
            list.Add("Gatorade"); //[1]
            list.Add("Lemonade"); //[2]
            list.Add("Iced Tea"); //[3]
            list.Add("Water"); //[4]
            list.Remove[0];
            string actualResult = list[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        public void ToString()
        {

            //Arange
            CustomList list = new CustomList();
            string actualResult;
            
            //Act
            actualResult = list[0].GetType();

            //Assert
            Assert.IsTrue(actualResult = string);

        }


    }
}
