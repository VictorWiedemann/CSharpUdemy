using System;
using System.Collections.Generic;

namespace CSharpUdemy
{
    public class Stack
    {
        public Stack<object> StackList { get; set; }
        
        public Stack()
        {
            StackList = new Stack<object>();
            StackList.Clear();
        }

        public void clear()
        {
            StackList.Clear();
        }

        public void Push(object stackItem)
        {
            StackList.Push(stackItem);
        }

        public object Pop()
        {
            var didPop = StackList.TryPop(out object popItem);
            if (!didPop)
            {
                throw new InvalidOperationException();
            }

            return popItem;
        }
    }
}