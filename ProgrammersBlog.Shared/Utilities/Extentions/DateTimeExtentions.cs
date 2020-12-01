using System;

namespace ProgrammersBlog.Shared.Utilities.Extentions
{
    public static class DateTimeExtentions
    {
        public static string FullDateAndTimeStringWithUnderscore(this DateTime dateTime)
        {
            return
                $"{dateTime.Millisecond}_{dateTime.Second}_{dateTime.Minute}_{dateTime.Hour}_{dateTime.Day}_{dateTime.Month}_{dateTime.Year}";
        }
    }

}
