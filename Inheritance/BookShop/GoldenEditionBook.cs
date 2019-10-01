namespace BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string authorName, string title, decimal price)
            : base(authorName, title, price)
        {
        }

        public override decimal Price
        {
            get => base.Price * 1.3m;
        }
    }
}
