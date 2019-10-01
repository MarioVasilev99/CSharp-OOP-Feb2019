namespace Telephony
{
    public interface IBrowsable
    {
        string[] SitesToBrowse { set; }

        string Browse();
    }
}
