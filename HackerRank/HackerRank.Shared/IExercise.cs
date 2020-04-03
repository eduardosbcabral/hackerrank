using System;

namespace HackerRank.Shared
{
    public interface IExercise<T>
    {
        T Execute();
    }
}
