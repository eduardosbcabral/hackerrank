using HackerRank.Shared;

namespace HackerRank.Algorithms.Exercises
{
    public class TimeConversion : IExercise<string>
    {
        public string Date { get; private set; }

        /// <summary>
        /// <para>Time Conversion</para>
        /// <para>Order: 10</para>
        /// <para>Description: Given a time in -hour AM/PM format, convert it to military (24-hour) time.</para>
        /// </summary>
        /// <param name="date">Contains a date in 12-hour AM/PM format.</param>
        public TimeConversion(string date)
        {
            Date = date;
            CheckConstraints();
        }

        public string Execute()
        {
            var hours = GetHours();
            var format = GetDateFormat();

            var hoursNumber = int.Parse(hours);

            if (format == "PM" && hoursNumber != 12)
                hoursNumber += 12;
            if (format == "AM" && hoursNumber == 12)
                hoursNumber = 0;

            return MergeDate(hoursNumber >= 10 ? hoursNumber.ToString() : hoursNumber.ToString("D2"));
        }

        public string GetHours()
        {
            return Date.Split(':')[0];
        }

        public string GetMinutes()
        {
            return Date.Split(':')[1];
        }

        public string GetSeconds()
        {
            return Date.Split(':')[2][..^2];
        }

        public string GetDateFormat()
        {
            return Date[^2..].ToString();
        }

        public string MergeDate(string hour)
        {
            return $"{hour}:{GetMinutes()}:{GetSeconds()}";
        }

        public void CheckConstraints()
        {
            var hours = int.Parse(GetHours());
            if (hours < 1 || hours > 12)
                throw new ConstraintException(hours);

            var minutes = int.Parse(GetMinutes());
            if (hours < 0 || hours > 60)
                throw new ConstraintException(minutes);

            var seconds = int.Parse(GetSeconds());
            if (seconds < 0 || seconds > 60)
                throw new ConstraintException(minutes);

            var format = GetDateFormat();
            if (format != "AM" && format != "PM")
                throw new ConstraintException(format);
        }
    }
}
