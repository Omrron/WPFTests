using System.Windows;

namespace WPF_Buttons.Extensions
{
    public static class DurationExtensions
    {
        public static Duration Multiply(this Duration duration, int multiplier)
        {
           return duration.TimeSpan * multiplier;
        }

    }
}
