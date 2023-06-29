namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> nameOfGames = new List<string>() { "Madden 25", "Super Smash Bros", "Cod", "Super Mario Bros" };

            var lengthOfGameName = nameOfGames.OrderBy(x => x.Length);
            foreach (var x in lengthOfGameName)
            {
                Console.WriteLine(x);
            }
        }
    }
}
