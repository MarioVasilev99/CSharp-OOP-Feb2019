namespace MordorsCruelPlan
{
    public class MoodFactory
    {
        private int foodHappinessPoints;

        public MoodFactory(int foodHappinessPoints)
        {
            this.foodHappinessPoints = foodHappinessPoints;
        }

        public string GetMood()
        {
            string mood = this.CalculateMood();

            return mood;
        }

        private string CalculateMood()
        {
            string moodToReturn = string.Empty;

            if (this.foodHappinessPoints < -5)
            {
                moodToReturn = "Angry";
            }
            else if (this.foodHappinessPoints >= -5 && this.foodHappinessPoints <= 0)
            {
                moodToReturn = "Sad";
            }
            else if (this.foodHappinessPoints >= 1 && this.foodHappinessPoints <= 15)
            {
                moodToReturn = "Happy";
            }
            else if (this.foodHappinessPoints > 15)
            {
                moodToReturn = "JavaScript";
            }

            return moodToReturn;
        }
    }
}