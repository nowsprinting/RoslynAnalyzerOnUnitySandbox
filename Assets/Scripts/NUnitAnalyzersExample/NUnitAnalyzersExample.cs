// Copyright (c) 2021 Koji Hasegawa.
// This software is released under the MIT License.

using NUnit.Framework;

namespace NUnitAnalyzersExample
{
    public class NUnitAnalyzersExample
    {
        [TestCase(true)]
        public void SampleTest(int numberValue)
        {
            Assert.That(numberValue, Is.EqualTo(1));
        }

        [TestCaseSource("MyTestSource")]
        public void SampleTest(string stringValue)
        {
            Assert.That(stringValue.Length, Is.EqualTo(3));
        }

        public static object[] MyTestSource()
        {
            return new object[] { "One", "Two" };
        }

        [TestCase("1")]
        public void NUnit1003SampleTest(string parameter1, string parameter2)
        {
            Assert.That(parameter1, Is.EqualTo("1"));
            Assert.That(parameter2, Is.EqualTo("2"));
        }

        [TestCase("1", "2")]
        public void NUnit1004SampleTest(string parameter1)
        {
            Assert.That(parameter1, Is.EqualTo("1"));
        }

        [TestCase(1, ExpectedResult = true)]
        public int NUnit1005SampleTest(int inputValue)
        {
            return inputValue;
        }

        [TestCase(1, ExpectedResult = "1")]
        public void NUnit1006SampleTest(int inputValue)
        {
            return;
        }

        [TestCase(1)]
        public string NUnit1007SampleTest(int inputValue)
        {
            return "";
        }

        [TestCaseSource("MyIncorrectTestSource")]
        public void NUnit1011SampleTest(string stringValue)
        {
            Assert.That(stringValue.Length, Is.EqualTo(3));
        }
    }
}
