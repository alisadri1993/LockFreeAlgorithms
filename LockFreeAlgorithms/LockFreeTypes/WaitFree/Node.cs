namespace LockFreeAlgorithms.LockFreeTypes.WaitFree;
public class Node<T>
{
    public T Value;
    public Node<T> Next;

    public Node(T value)
    {
        Value = value;
        Next = null;
    }
}
