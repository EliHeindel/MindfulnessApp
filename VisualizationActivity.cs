namespace MindfulnessApp
{
    using System;

    public class VisualizationActivity : Activity
    {
        private static readonly string[] Prompts = {
            "Imagine yourself on a serene beach, the waves gently crashing on the shore.",
            "Visualize a quiet forest with the sounds of birds chirping and a gentle breeze.",
            "Picture yourself in a peaceful garden, surrounded by blooming flowers and the scent of fresh blooms.",
            "Imagine floating on a calm lake, the water gently rocking you."
        };

        public VisualizationActivity()
        {
            Name = "Visualization";
            Description = "This activity will help you relax by visualizing peaceful and calming scenes.";
        }

        protected override void RunActivity()
        {
            Random rand = new Random();
            string prompt = Prompts[rand.Next(Prompts.Length)];
            Console.WriteLine(prompt);
            ShowAnimation(5);

            DateTime endTime = DateTime.Now.AddSeconds(Duration);

            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Visualize this scene in detail...");
                ShowAnimation(10);
            }
        }
    }
}
