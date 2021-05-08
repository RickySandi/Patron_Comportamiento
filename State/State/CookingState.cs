using System;
namespace State
{
    public class CookingState: ICookState
    {
        public void HandleOperation(Cook cookContext)
        {
            Console.WriteLine("{0}: Cook is cooking", nameof(CookingState));
            cookContext.CookState = new CookEndState();
            cookContext.CookState.HandleOperation(cookContext);
        }
    }
}
