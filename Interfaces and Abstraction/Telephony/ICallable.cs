namespace Telephony
{
    interface ICallable
    {
        string[] NumbersToCall { set; }

        string Call();
    }
}
