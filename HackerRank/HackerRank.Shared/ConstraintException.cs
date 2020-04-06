using System;

namespace HackerRank.Shared
{
    public class ConstraintException : Exception
    {
        public ConstraintException(object message) 
            : base($"Input did not satisfy one or more constraints: {message}")
        {

        }
    }
}
