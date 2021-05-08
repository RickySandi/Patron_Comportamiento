using System;
namespace State
{
    public class Cook
    {
        private ICookState _cookState;

        public Cook()
        {
            _cookState = new ReadyState(); 
        }

        public ICookState CookState
        {
            get
            {
                return _cookState;
            }
            set
            {
                _cookState = value;
            }
        }

        public void Cooking()
        {
            Console.WriteLine("Cooking starts...");
            _cookState = new CookStartState();
            _cookState.HandleOperation(this);

        }
    }
}
