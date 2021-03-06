﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenSoundControl;

namespace UnitTests
{
    ///<summary>
    ///  This is a test class for OscStringTest and is intended
    ///  to contain all OscStringTest Unit Tests
    ///</summary>
    [TestClass]
    public class OscStringTest
    {
        ///<summary>
        ///  Gets or sets the test context which provides
        ///  information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        #region Additional test attributes

        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //

        #endregion

        ///<summary>
        ///  A test for OscString Constructor
        ///</summary>
        [TestMethod]
        public void OscStringConstructorTest()
        {
            string value = "/servo/0/position";
            var target = new OscString(value);
            Assert.AreEqual(target.Value, value);
        }

        ///<summary>
        ///  A test for OscString Constructor
        ///</summary>
        [TestMethod]
        public void OscStringConstructorTest1()
        {
            var target = new OscString();
            Assert.AreEqual(target.Value, String.Empty);
        }

        ///<summary>
        ///  A test for ToOscPacketArray
        ///</summary>
        [TestMethod]
        public void ToOscPacketArrayTest()
        {
            var target = new OscString("/test");
            var expected = new byte[] { 0x2f, 0x74, 0x65, 0x73, 0x74, 0, 0, 0 };
            byte[] actual;
            actual = target.ToOscPacketArray();
            Assert.IsTrue(actual.Length == expected.Length, "Array size not equal");
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.IsTrue(expected[i] == actual[i], String.Format("expected[{0}] != actual[{0}]", i));
            }
        }

        ///<summary>
        ///  A test for ToString
        ///</summary>
        [TestMethod]
        public void ToStringTest()
        {
            var target = new OscString("/servo/0/position");
            string expected = "/servo/1/position";
            target.Value = expected;
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }

        ///<summary>
        ///  A test for ElementType
        ///</summary>
        [TestMethod]
        public void ElementTypeTest()
        {
            var target = new OscString();
            OscElementType actual;
            actual = target.ElementType;
            Assert.AreEqual(actual, OscElementType.String);
        }

        ///<summary>
        ///  A test for IsArgument
        ///</summary>
        [TestMethod]
        public void IsArgumentTest()
        {
            var target = new OscString();
            bool actual;
            actual = target.IsArgument;
            Assert.AreEqual(actual, true);
        }

        ///<summary>
        ///  A test for Value
        ///</summary>
        [TestMethod]
        public void ValueTest()
        {
            var target = new OscString("/servo/0/position");
            string expected = "/servo/1/position";
            string actual;
            target.Value = expected;
            actual = target.Value;
            Assert.AreEqual(expected, actual);
        }
    }
}
