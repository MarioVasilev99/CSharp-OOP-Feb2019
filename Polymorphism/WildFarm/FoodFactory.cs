namespace WildFarm
{
    using WildFarm.Foods;

    public static class FoodFactory
    {
        public static Food Create(string[] foodInfo)
        {
            string foodType = foodInfo[0];
            int quantity = int.Parse(foodInfo[1]);

            switch (foodType)
            {
                case "Vegetable":
                    return new Vegetable(quantity);

                case "Seeds":
                    return new Seeds(quantity);

                case "Meat":
                    return new Meat(quantity);

                case "Fruit":
                    return new Fruit(quantity);
            }

            return null;
        }
    }
}
