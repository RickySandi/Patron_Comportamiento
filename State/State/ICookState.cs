using System;
namespace State
{
    public interface ICookState
    {
        void HandleOperation(Cook cookContext); 
    }
}
