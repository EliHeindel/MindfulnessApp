namespace MindfulnessApp
{
    using System;

    public class GratitudeActivity : Activity
    {
        public GratitudeActivity()
        {
            Name = "Gratitude";
            Description = "This activity will help you focus on the things you are grateful for in your life.";
        }

        protected override void RunActivity()
        {
            Console.WriteLine("Think about the things you are grateful for...");
            ShowAnimation(5);

            Console.WriteLine("Start listing...");
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            int itemCount = 0;

            while (DateTime.Now < endTime)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrEmpty(item)) itemCount++;
            }

            Console.WriteLine($"You listed {itemCount} items you are grateful for.");
        }
    }
}
