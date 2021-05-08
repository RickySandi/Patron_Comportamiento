using System;
namespace State
{
    public class ReadyState : ICookState
    {
        public void HandleOperation(Cook cookContext)
        {
            Console.WriteLine("Cook is Ready.");
        }
    }
}
