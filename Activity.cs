namespace MindfulnessApp
{
    using System;
    using System.Threading;

    public abstract class Activity
    {
        protected string Name { get; set; }
        protected string Description { get; set; }
        protected int Duration { get; set; }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine($"Starting {Name} Activity");
            Console.WriteLine(Description);
            Console.Write("Enter the duration in seconds: ");
            Duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            ShowAnimation(3);

            RunActivity();

            ActivityLogger.Log(Name, Duration);

            Console.WriteLine("Well done!");
            Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
            ShowAnimation(3);
        }

        protected abstract void RunActivity();

        protected void ShowAnimation(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
