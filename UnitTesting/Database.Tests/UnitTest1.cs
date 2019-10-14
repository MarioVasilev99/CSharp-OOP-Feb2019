namespace Tests
{
    using NUnit.Framework;
    using Database;
    using System;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void Constructor_ShouldThrowInvalidOperationException_WhenArgumentsAreMoreThan16()
        {
            Assert
                .Throws<InvalidOperationException>(()
                => new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17));
        }

        [Test]
        public void AddMethod_ShouldAddElementAtTheNextFreeCell()
        {
            var newDatabase = new Database(1, 2, 3);
            int expectedElement = 4;

            newDatabase.Add(expectedElement);

            int[] updatedDatabase = newDatabase.Fetch();
            int elementAdded = updatedDatabase[3];

            Assert.AreEqual(expectedElement, elementAdded);
        }

        [Test]
        public void AddMethod_ShouldThrowInvalidOperationException_WhenDatabaseIsFull()
        {
            int[] databaseElements = new int[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16
            };

            var fullDatabase = new Database(databaseElements);

            Assert.Throws<InvalidOperationException>(() => fullDatabase.Add(2));
        }

        [Test]
        public void RemoveMethod_ShouldRemoveOnlyOneElement()
        {
            var database = new Database(1, 2, 3);

            database.Remove();

            int expectedDatabaseElements = 2;
            int actualDatabaseElements = database.Fetch().Length;

            Assert.AreEqual(expectedDatabaseElements, actualDatabaseElements);
        }

        [Test]
        public void RemoveMethod_ShouldThrowInvalidOperationException_WhenDatabaseIsEmpty()
        {
            var emptyDatabase = new Database();

            Assert.Throws<InvalidOperationException>(() => emptyDatabase.Remove());
        }

        [Test]
        public void FetchMethod_ShouldReturnDatabaseElementsAsArray()
        {
            var database = new Database(1, 2, 3);

            int[] databaseElements = database.Fetch();
            int[] expectedDatabaseElements = new int[] { 1, 2, 3 };

            CollectionAssert.AreEqual(expectedDatabaseElements, databaseElements);
        }
    }
}