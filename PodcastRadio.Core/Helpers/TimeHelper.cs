﻿using System;
namespace PodcastRadio.Core.Helpers
{
    public static class TimeHelper
    {
        public static string SecondsToDuration(string value)
        {
            int seconds = 0;
            Int32.TryParse(value, out seconds);
            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
            return timeSpan.ToString(@"hh\:mm\:ss");
        }
    }
}
