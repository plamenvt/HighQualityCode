namespace IfStatements
{
    using System;
    using Cooking;

    public class IfStatementsRefactored
    {
        public static void Main()
        {
            Potato potato = new Potato();

            if (potato != null)
            {
                if (potato.IsPeeled && !potato.IsRotten)
                {
                    potato.Cook();
                }
            }
        }
    }
}
