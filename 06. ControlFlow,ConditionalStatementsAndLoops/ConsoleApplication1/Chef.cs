namespace Cooking
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);
            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);
            Bowl bowl = this.GetBow();
            bowl.Add(potato);
            bowl.Add(carrot);
        }

        private Bowl GetBow()
        {
            Bowl result = new Bowl();
            return result;
        }

        private Carrot GetCarrot()
        {
            Carrot result = new Carrot();
            return result;
        }

        private Potato GetPotato()
        {
            Potato result = new Potato();
            return result;
        }

        private void Cut(Vegetables vegetable)
        {
            vegetable.IsCut = true;
        }

        private void Peel(Vegetables vegetable)
        {
            vegetable.IsPeeled = true;
        }
    }
}
