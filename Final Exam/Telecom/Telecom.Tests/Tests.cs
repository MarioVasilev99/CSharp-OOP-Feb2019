namespace Telecom.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Tests
    {

        [Test]
        public void Constructor_ShouldInitialiseCorrectlyValues()
        {
            var phone = new Phone("LG", "G2");

            string expectedMake = "LG";
            string expectedModel = "G2";

            string actualMake = phone.Make;
            string actualModel = phone.Model;

            Assert.AreEqual(expectedMake, actualMake);
            Assert.AreEqual(expectedModel, actualModel);
            Assert.AreEqual(phone.Count, 0);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void MakeSetter_ShouldThrowArgumentException_WhenPassedInvalidValue(string make)
        {
            Assert.Throws<ArgumentException>(() => new Phone(make, "S2"));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void ModelSetter_ShouldThrowArgumentException_WhenPassedInvalidValue(string model)
        {
            Assert.Throws<ArgumentException>(() => new Phone("LG", model));
        }

        [Test]
        public void CountMethod_ShouldReturnCorrectValue()
        {
            var phone = new Phone("LG", "G2");

            phone.AddContact("Pesho", "0092829");

            int expectedCountValue = 1;
            int actualCountValue = phone.Count;

            Assert.AreEqual(expectedCountValue, actualCountValue);
        }

        [Test]
        public void AddContactMethod_ShouldThrowInvalidOperationException_WhenContactAlreadyExists()
        {
            var phone = new Phone("LG", "G2");
            phone.AddContact("Pesho", "0092829");

            Assert.Throws<InvalidOperationException>(() => phone.AddContact("Pesho", "0092829"));
        }

        [Test]
        public void CallMethod_ShouldThrowInvalidOperationException_WhenNumberDoesntExist()
        {
            var phone = new Phone("LG", "G2");

            Assert.Throws<InvalidOperationException>(() => phone.Call("ivan"));
        }

        [Test]
        public void CallMethod_ShouldReturnCorrectMessage_WhenCalled()
        {
            var phone = new Phone("LG", "G2");
            phone.AddContact("Pesho", "0092829");

            string expectedMessage = $"Calling Pesho - 0092829...";
            string actualMessage = phone.Call("Pesho");

            Assert.AreEqual(expectedMessage, actualMessage);
        }

    }
}