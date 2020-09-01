using System;
using ClassRoom;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassRoomUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(12)]
        [DataRow(1)]
        [DataRow(2)]
        public void TestStudentsSeasonWinter(int value)
        {
            Student student = new Student("test", value, 5);

            string season = student.Season();

            Assert.AreEqual("Winter", season);
        }
        [DataTestMethod]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        public void TestStudentsSeasonSpring(int value)
        {
            Student student = new Student("test", value, 5);

            string season = student.Season();

            Assert.AreEqual("Spring", season);
        }
        [DataTestMethod]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(8)]
        public void TestStudentsSeasonSummer(int value)
        {
            Student student = new Student("test", value, 5);

            string season = student.Season();

            Assert.AreEqual("Summer", season);
        }
        [DataTestMethod]
        [DataRow(9)]
        [DataRow(10)]
        [DataRow(11)]
        public void TestStudentsSeasonAutumn(int value)
        {
            Student student = new Student("test", value, 5);

            string season = student.Season();

            Assert.AreEqual("Autumn", season);
        }



        [DataTestMethod]
        [DataRow(0)]
        [DataRow(13)]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentsSeasonInvalid(int value)
        {
            Student student = new Student("test", value, 5);

            Assert.Fail();
        }

    }
}
