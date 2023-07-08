public class Stack
{
    private List<string> _stack = new();

    public int Size{
        get{ return _stack.Count;}
    }

    public string? Top{
        get { return _stack.Count == 0 ? null : _stack.Last(); }
    }

    public Stack(){}

    public Stack(params string[] items)
    {
        _stack.AddRange(items);
    }

    public void Add(string item) => 
        _stack.Add(item);

    public string Pop()
    {
        if(_stack.Count == 0)
            throw new Exception("Стек пустой");
        string lastItem = _stack.Last();
        _stack.Remove(lastItem);
        return lastItem;
    }
}