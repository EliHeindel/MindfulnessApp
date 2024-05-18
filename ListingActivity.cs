namespace MindfulnessApp
{
    using System;

    public class ListingActivity : Activity
    {
        private static readonly string[] Prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity()
        {
            Name = "Listing";
            Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }

        protected override void RunActivity()
        {
            Random rand = new Random();
            string prompt = Prompts[rand.Next(Prompts.Length)];
            Console.WriteLine(prompt);
            ShowAnimation(5);

            Console.WriteLine("Start listing...");
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            int itemCount = 0;

            while (DateTime.Now < endTime)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrEmpty(item)) itemCount++;
            }

            Console.WriteLine($"You listed {itemCount} items.");
        }
    }
}
