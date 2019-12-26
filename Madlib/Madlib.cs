using System;

namespace Game
{
    static class Madlib
    {
        // declare variables
        static string creature;
        static string luminous;
        static string ghastly;
        static string spectral;
        static string countryman;
        static string farrier;
        static string farmer;
        static string dreadful;
        static string apparition;
        static string hound;

        // Method with statements
        public static void Run()
        {
            Start();
            GetWords();
            WriteStory();
            End();
        }

        static void Start()
        {
            // write out a header
            Console.WriteLine("----------");
            Console.WriteLine("Madlib!");
            Console.WriteLine("----------");
            Console.WriteLine("They all agreed that it was a huge creature, luminous, ghastly, and spectral. I have cross-examined these men, one of them a hard-headed countryman, one a farrier, and one a moorland farmer, who all tell the same story of this dreadful apparition, exactly corresponding to the hell-hound of the legend.");
            Console.WriteLine("----------");
        }

        static void GetWords()
        {
            // ask player to enter words
            Console.Write($"Please enter a noun: ");
            creature = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            luminous = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            ghastly = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            spectral = Console.ReadLine();

            Console.Write("Please enter an occupation: ");
            countryman = Console.ReadLine();

            Console.Write("Please enter an occupation: ");
            farrier = Console.ReadLine();

            Console.Write("Please enter an occupation: ");
            farmer = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            dreadful = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            apparition = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            hound = Console.ReadLine();
        }

        static void WriteStory()
        {
            // write out finished story
            string story = $"They all agreed that it was a huge {creature}, {luminous}, {ghastly}, and {spectral}. I have cross-examined these men, one of them a hard-headed {countryman}, one a {farrier}, and one a moorland {farmer}, who all tell the same story of this {dreadful} {apparition}, exactly corresponding to the {hound} of the legend.";
            Console.WriteLine(story);
        }

        static void End()
        {
            // keep window open and prompt for exit
            Console.WriteLine("----------");
            Console.WriteLine("Press Enter to exit");
            Console.ReadKey();

        }
    }
}