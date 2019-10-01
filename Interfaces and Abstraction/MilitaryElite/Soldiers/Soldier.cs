namespace MilitaryElite.Soldiers
{
    using MilitaryElite.ISoldiers;

    public abstract class Soldier : ISoldier
    {
        public Soldier(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public abstract override string ToString();
    }
}
