namespace Tests
{
    using NUnit.Framework;
    using ExtendedDatabase;
    using System;

    public class Tests
    {
        [Test]
        public void AddMethod_ShouldThrowInvalidOperationException_WhenAddingPersonWithExistingUsername()
        {
            var newPerson = new Person(2, "Pesho");
            var database = new Database(newPerson);

            var personWithExistingUsername = new Person(3, "Pesho");

            Assert.Throws<InvalidOperationException>(() => database.Add(personWithExistingUsername));
        }

        [Test]
        public void AddMethod_ShouldThrowInvalidOperationException_WhenAddingPersonWithExistingId()
        {
            var newPerson = new Person(1, "Pesho");
            var database = new Database(newPerson);

            var personWithExistingId = new Person(1, "Gosho");

            Assert.Throws<InvalidOperationException>(() => database.Add(personWithExistingId));
        }

        [Test]
        public void FindByUserNameMethod_ShouldThrowInvalidOperationException_WhenUsernameNotFound()
        {
            var newPerson = new Person(1, "Pesho");
            var database = new Database(newPerson);

            Assert
                .Throws<InvalidOperationException>(() => database.FindByUsername("InvalidUsername"));
        }

        [Test]
        public void
            FindByUsernameMethod_ShouldThrowArgumentNullException_WhenUsernameArgumentIsNull()
        {
            var database = new Database();

            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(null));
        }

        [Test]
        public void FindByIdMethod_ShouldThrowInvalidOperationException_WhenNoSuchUserWithIdExists()
        {
            var newPerson = new Person(1, "Pesho");
            var database = new Database(newPerson);

            Assert.Throws<InvalidOperationException>(() => database.FindById(3));
        }

        [Test]
        public void FindByIdMethod_ShouldThrowArgumentOutOfRangeException_WhenArgumentIdIsNegative()
        {
            var database = new Database();

            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(-1));
        }
    }
}