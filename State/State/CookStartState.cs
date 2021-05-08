using System;
namespace State
{
    public class CookStartState: ICookState
    {
        public void HandleOperation(Cook cookContext)
        {
            Console.WriteLine("{0}: Cook starts cooking", nameof(CookStartState));
            cookContext.CookState = new CookingState();
            cookContext.CookState.HandleOperation(cookContext);

        }
    }
}
