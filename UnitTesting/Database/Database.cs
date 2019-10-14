namespace Database
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Database
    {
        private readonly int[] database;
        private int index;
        private const int DefaultDatabaseSize = 16;

        public Database(params int[] collection)
        {
            this.ValidateInputElements(collection.ToArray());
            this.database = new int[DefaultDatabaseSize];
            this.index = default(int);
            this.AddCollectionToDatabase(collection);
        }

        public Database(ICollection<int> collection)
            : this(collection.ToArray())
        {
        }

        public void Add(int elementToAdd)
        {
            this.FullDatabaseCheck();

            this.database[this.index] = elementToAdd;
        }

        public void Remove()
        {
            this.EmptyDatabaseCheck();

            this.database[index - 1] = default(int);
        }

        public int[] Fetch()
        {
            var databaseElements = new List<int>();

            foreach (var element in this.database)
            {
                if (element != default(int))
                {
                    databaseElements.Add(element);
                }
            }

            return databaseElements.ToArray();
        }

        private void EmptyDatabaseCheck()
        {
            if (this.index == default(int))
            {
                throw new InvalidOperationException("Database is empty.");
            }
        }

        private void FullDatabaseCheck()
        {
            if (this.index == DefaultDatabaseSize)
            {
                throw new InvalidOperationException("Database is full.");
            }
        }

        private void AddCollectionToDatabase(int[] collection)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                database[index] = collection[i];
                index++;
            }
        }

        private void ValidateInputElements(int[] elements)
        {
            if (elements.Length > 16)
            {
                throw new InvalidOperationException("Elements must be 16 or less.");
            }
        }
    }
}
