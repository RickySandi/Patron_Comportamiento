using System;
namespace State
{
    public class CookEndState : ICookState
    {
        public void HandleOperation(Cook cookContext)
        {
            Console.WriteLine("{0}: Food is complete", nameof(CookEndState));
            cookContext.CookState = new ReadyState();
            cookContext.CookState.HandleOperation(cookContext);
        }
            
    }
}
