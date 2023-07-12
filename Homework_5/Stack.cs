namespace Stackspace
{
    public class Stack
    {
        private List<StackItem> _stack = new();

        public int Size{
            get{ return _stack.Count;}
        }

        public string? Top{
            get { return _stack.Count == 0 ? null : _stack.Last().StackItemValuec; }
        }

        public Stack(){}

        public Stack(params string[] items)
        {
            for (int i = 0; i < items.Length; i++)
                Add(items[i]);
            
        }

        public void Add(string item) => 
            _stack.Add(new StackItem(item, _stack));

        public string? Pop()
        {
            if(_stack.Count == 0)
                throw new Exception("Стек пустой");
            var lastItem = _stack.Last();
            _stack.Remove(lastItem);
            return lastItem.StackItemValuec;
        }

        public static Stack Concat(params Stack[] stacks)
        {
            var stack = new Stack();
            for(int i = 0; i < stacks.Length; i++)
            {
                stack.Merge(stacks[i]);
            }
            return stack;
        }

        private class StackItem
        {
            private string? value;
            private StackItem? previousItem;
            
            public string? StackItemValuec
            {
                get {
                    return value;
                }
            }

            public StackItem? PreviousItem{
                get{
                    return previousItem;
                }
            }

            public StackItem(string item, List<StackItem> stack)
            {
                value = item;
                if(stack.Count > 0)
                    previousItem = stack.Last();
            }
        }
    }

    
}