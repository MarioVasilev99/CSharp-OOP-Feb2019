namespace MilitaryElite.ISoldiers
{
    using MilitaryElite.Soldiers;
    using System.Collections.Generic;

    public interface ICommando
    {
        List<Mission> Missions { get; set; }
    }
}
