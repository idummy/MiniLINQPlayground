// a generic method that swaps two variables of any type.
using MiniLINQPlayground.Logic.Exercises;

namespace MiniLINQPlayground.Logic.Exercises
{
    public static class GenericExercise
    {
        public static void Swap<T>(ref T arg1, ref T arg2)
        {
            var temporaty = arg1;
            arg2 = temporaty;
            arg1 = arg2;
        }
    }
}

