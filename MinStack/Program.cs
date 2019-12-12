using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MinStack obj = new MinStack();
            obj.Push(x);
            obj.Pop();
            int param_3 = obj.Top();
            int param_4 = obj.GetMin();
        }
    }

    public class MinStack
    {
        private Stack<(int Value, int Min)> _stack;

        public MinStack()
        {
            _stack = new Stack<(int, int)>();
        }

        public void Push(int x)
        {
            var min = _stack.Any() ? Math.Min(x, GetMin()) : x;
            _stack.Push(new ValueTuple<int, int>(x, min));
        }

        public void Pop()
        {
            _stack.Pop();
        }

        public int Top()
        {
            return _stack.Peek().Value;
        }

        public int GetMin()
        {
            return _stack.Peek().Min;
        }
    }

}
