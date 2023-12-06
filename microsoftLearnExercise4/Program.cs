namespace microsoftLearnExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);
            //var result = new string(valueArray);
            var result = String.Join(",", valueArray);

            Console.WriteLine(result);

            string[] items = result.Split(",");
            foreach ( string item in items )
            {
                Console.WriteLine(item);
            }
        }
    }
}
