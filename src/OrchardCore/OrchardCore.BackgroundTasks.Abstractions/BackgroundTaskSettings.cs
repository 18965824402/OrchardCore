using System;

namespace OrchardCore.BackgroundTasks
{
    public class BackgroundTaskSettings
    {
        public static BackgroundTaskSettings None = new BackgroundTaskSettings() { Enable = false };

        public string Name { get; set; } = String.Empty;
        public bool Enable { get; set; } = true;
        public string Schedule { get; set; } = "* * * * *";
        public string Description { get; set; } = String.Empty;
    }
}