namespace ExtendedDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Database
    {
        private readonly List<Person> database;

        public Database(params Person[] collection)
        {
            this.database = new List<Person>();
            this.AddCollectionToDatabase(collection);
        }

        public Database(ICollection<Person> collection)
            : this(collection.ToArray())
        {
        }

        public Person FindByUsername(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException("Invalid Username!");
            }

            bool PersonIsInDatabase = this.CheckIfExistsByUsername(username);

            if (!PersonIsInDatabase)
            {
                this.ThrowPersonNotFoundException();
            }

            var personNeeded = this.database.FirstOrDefault(p => p.UserName == username);
            return personNeeded;
        }

        public Person FindById(long id)
        {
            this.ValidateId(id);

            bool personIsInDatabase = this.CheckIfExistsById(id);

            if (!personIsInDatabase)
            {
                this.ThrowPersonNotFoundException();
            }

            var personFound = this.database.FirstOrDefault(p => p.Id == id);

            return personFound;
        }
        
        public void Add(Person personToAdd)
        {
            this.ValidatePerson(personToAdd);
            this.database.Add(personToAdd);
        }

        public void Remove()
        {
            this.EmptyDatabaseCheck();

            int lastIndex = this.database.Count - 1;

            this.database.RemoveAt(lastIndex);
        }

        private void AddCollectionToDatabase(Person[] collection)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                var personToAdd = collection[i];
                database.Add(personToAdd);
            }
        }

        private bool CheckIfExistsByUsername(string username)
        {
            var peopleFound = this.database.Where(p => p.UserName == username).ToList();

            if (peopleFound.Count == 0)
            {
                return false;
            }

            return true;
        }

        private bool CheckIfExistsById(long id)
        {
            var peopleFoundById = this.database.Where(p => p.Id == id).ToList();

            if (peopleFoundById.Count == 0)
            {
                return false;
            }

            return true;
        }

        private void ValidateId(long id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid id");
            }
        }

        private void ValidatePerson(Person personToAdd)
        {
            long personId = personToAdd.Id;
            string personUsername = personToAdd.UserName;

            bool suchUserIdExists = this.CheckIfExistsById(personId);
            bool suchUsernameExists = this.CheckIfExistsByUsername(personUsername);

            if (suchUserIdExists || suchUsernameExists)
            {
                throw new InvalidOperationException("Person with such username or Id already exists.");
            }
        }

        private void ThrowPersonNotFoundException()
        {
            throw new InvalidOperationException("No such user in database.");
        }

        private void EmptyDatabaseCheck()
        {
            if (this.database.Count == 0)
            {
                throw new InvalidOperationException("Empty database.");
            }
        }
    }
}
