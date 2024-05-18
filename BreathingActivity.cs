namespace MindfulnessApp
{
    using System;

    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            Name = "Breathing";
            Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        protected override void RunActivity()
        {
            int halfDuration = Duration / 2;
            for (int i = 0; i < halfDuration; i++)
            {
                Console.WriteLine("Breathe in...");
                ShowAnimation(5);
                Console.WriteLine("Breathe out...");
                ShowAnimation(5);
            }
        }
    }
}
