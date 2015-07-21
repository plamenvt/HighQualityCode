namespace Task1.ConvertBoolToString
{
    using System;

    public class BooleanToStringConvertor
    {
        public static void CreateConvertor()
        {
            var convertor = new Convertor();
            convertor.ConvertBoolToString(true);
        }

        private class Convertor
        {
            public void ConvertBoolToString(bool inputBoolean)
            {
                string booleanAsString = inputBoolean.ToString();
                Console.WriteLine(booleanAsString);
            }
        }
    }
}