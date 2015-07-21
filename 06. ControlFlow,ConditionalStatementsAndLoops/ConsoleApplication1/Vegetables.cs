namespace Cooking
{
    public class Vegetables
    {
        public bool IsPeeled { get; set; }

        public bool IsCut { get; set; }

        public bool IsCooked { get; set; }

        public void Cook()
        {
            this.IsCooked = true;
        }
    }
}
