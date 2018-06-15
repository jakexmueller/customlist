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

        public void Remove()
        {
            //Arange
            CustomList<int> list = new CustomList<int>();           
            int result;

            //Act
            result = list.Remove(list[0]);

            //Assert
            Assert.IsNull(list);
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
