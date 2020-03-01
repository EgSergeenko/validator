using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProjectLab1
{
    using ValidationSystem;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expected = Tuple.Create(true, true);

            Student student = new Student("Ivan");
            student.DoTask("a");
            Validator v1 = new Validator("a");
            v1.AddStudent(student);
            v1.Validate(student);

            var actual = v1.Check(student);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var expected = Tuple.Create(true, false);

            Student student = new Student("Ivan");
            student.DoTask("a");
            Validator v1 = new Validator("aa");
            v1.AddStudent(student);
            v1.Validate(student);

            var actual = v1.Check(student);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var expected = Tuple.Create(false, false);

            Student student = new Student("Ivan");
            student.DoTask("a");
            Validator v1 = new Validator("aa");
            v1.Validate(student);

            var actual = v1.Check(student);
            Assert.AreEqual(expected, actual);
        }
    }
}
