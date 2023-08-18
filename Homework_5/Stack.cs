namespace Stackspace
{
    public class Stack
    {
        private StackItem _item;
        private int _size;

        public int Size
        {
            get { return _size; }
        }

        public string? Top
        {
            get { return _size == 0 ? null : _item.StackItemValuec; }
        }

        public Stack() { }

        public Stack(params string[] items)
        {
            for (int i = 0; i < items.Length; i++)
                Add(items[i]);

        }

        public void Add(string item)
        {
            StackItem newItem = new StackItem(item, _item);
            _item = newItem;
            _size++;
        }

        public string? Pop()
        {
            if (_size == 0)
                throw new Exception("Стек пустой");
            var lastItem = _item.StackItemValuec;
            _item = _item.PreviousItem;
            _size--;
            return lastItem;
        }

        public static Stack Concat(params Stack[] stacks)
        {
            var stack = new Stack();
            for (int i = 0; i < stacks.Length; i++)
            {
                stack.Merge(stacks[i]);
            }
            return stack;
        }
    }

    class StackItem
    {
        private string? value;
        private StackItem? previousItem;

        public string? StackItemValuec
        {
            get
            {
                return value;
            }
        }

        public StackItem? PreviousItem
        {
            get
            {
                return previousItem;
            }
        }

        public StackItem(string item, StackItem? stackItem)
        {
            value = item;
            previousItem = stackItem;
        }
    }
}


