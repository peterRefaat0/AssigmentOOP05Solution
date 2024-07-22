using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP05.Third_Project
{

    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Normalize();
        }

        public Duration(int seconds)
        {
            Hours = seconds / 3600;
            Minutes = (seconds % 3600) / 60;
            Seconds = seconds % 60;
            Normalize();
        }

        private void Normalize()
        {
            int totalSeconds = Hours * 3600 + Minutes * 60 + Seconds;
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }

        public override string ToString()
        {
            string result = "";
            if (Hours > 0)
            {
                result += $"Hours: {Hours}, ";
            }
            if (Minutes > 0 || Hours > 0)
            {
                result += $"Minutes: {Minutes}, ";
            }
            result += $"Seconds: {Seconds}";
            return result;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Duration)obj);
        }

        public bool Equals(Duration other)
        {
            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }

        public static Duration operator +(Duration d1, int seconds)
        {
            return d1 + new Duration(seconds);
        }

        public static Duration operator +(int seconds, Duration d1)
        {
            return d1 + seconds;
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return new Duration(totalSeconds1 - totalSeconds2);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return totalSeconds1 > totalSeconds2;
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return !(d1 > d2);
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1 > d2 || d1 == d2;
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1 < d2 || d1 == d2;
        }

        public static Duration operator ++(Duration d)
        {
            d.Seconds++;
            d.Normalize();
            return d;
        }

        public static Duration operator --(Duration d)
        {
            d.Seconds--;
            d.Normalize();
            return d;
        }

        public static explicit operator DateTime(Duration duration)
        {
            return new DateTime(1, 1, 1, duration.Hours, duration.Minutes, duration.Seconds);
        }
    }


}
