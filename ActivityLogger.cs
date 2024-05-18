namespace MindfulnessApp
{
    using System;
    using System.IO;

    public static class ActivityLogger
    {
        private static readonly string LogFilePath = "activity_log.txt";

        public static void Log(string activityName, int duration)
        {
            using StreamWriter writer = new StreamWriter(LogFilePath, true);
            writer.WriteLine($"{DateTime.Now}: {activityName} - {duration} seconds");
        }

        public static void DisplayLog()
        {
            if (File.Exists(LogFilePath))
            {
                string[] logLines = File.ReadAllLines(LogFilePath);
                foreach (var line in logLines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("No log entries found.");
            }
        }
    }
}
