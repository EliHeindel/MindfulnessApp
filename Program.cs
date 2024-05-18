// This program exceeds the requirements by implementing a logging system that tracks how many times each activity was performed. 
// The logs can be viewed through the menu system. Additionally, prompts and questions are managed to ensure unique selection per session.
// Two new activities, Gratitude and Visualization, have been added to provide more mindfulness opportunities for users.
namespace MindfulnessApp
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose an activity:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.WriteLine("4. Gratitude");
                Console.WriteLine("5. Visualization");
                Console.WriteLine("6. View Activity Log");
                Console.WriteLine("7. Exit");

                string choice = Console.ReadLine();
                Activity activity = choice switch
                {
                    "1" => new BreathingActivity(),
                    "2" => new ReflectionActivity(),
                    "3" => new ListingActivity(),
                    "4" => new GratitudeActivity(),
                    "5" => new VisualizationActivity(),
                    "6" => null,
                    "7" => null,
                    _ => null,
                };

                if (choice == "6")
                {
                    ActivityLogger.DisplayLog();
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                }
                else if (activity == null) break;
                else activity.Start();
            }
        }
    }
}
