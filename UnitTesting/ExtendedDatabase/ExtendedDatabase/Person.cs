namespace ExtendedDatabase
{
    public class Person
    {
        public Person(long id, string userName)
        {
            this.Id = id;
            this.UserName = userName;
        }

        public long Id { get; }

        public string UserName { get; }
    }
}
