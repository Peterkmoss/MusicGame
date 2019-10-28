using System;
namespace MusicGame.Models.Exceptions
{
    public class NotEnoughSpaceException : Exception
    {
        public NotEnoughSpaceException() : base("The room is too small!")
        {

        }
    }
}