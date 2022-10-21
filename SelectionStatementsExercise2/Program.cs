namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("You must understand number");
                    break;

                case "Science":
                    Console.WriteLine("You like to do experiments");
                    break;

                case "English":
                    Console.WriteLine("You like to exspress yourself in your writing");
                    break;

                case "History":
                    Console.WriteLine("You want to know the difference of today and the past");
                    break;

                default:
                    Console.WriteLine($"Oh wow! I haven't taken that subject before. {subject} sounds fun!");
                    break;

            }

        }
    }
}