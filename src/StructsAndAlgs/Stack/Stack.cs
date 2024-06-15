using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAndAlgs.Stack
{
    public class Stack<T>
    {
        private record StackItem(T Value, StackItem? Previous);

        private StackItem? _top;
        private int _count;

        public void Push(T item)
        {
            _top = new StackItem(item, _top);
            _count++;
        }

        public void Clear()
        {
            _top = null;
            _count = 0;
        }

        public void Pop()
        {
            if (_top is null)
            {
                throw new NullReferenceException("Stack is empty.");
            }
            _top = _top.Previous;
            _count--;
        }

        public T GetTop()
        {
            if (_top is null)
            {
                throw new NullReferenceException("Stack is empty.");
            }
            return _top.Value;
        }

        public int Count => _count;
    }
}
