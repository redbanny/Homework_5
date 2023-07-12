using Stackspace;
public static class StackExtensions
{
    public static void Merge(this Stack s1, Stack s2)
    {
        for (int i = s2.Size; i > 0; i--)
            s1.Add(s2.Pop());
    }
}