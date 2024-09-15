namespace LockFreeAlgorithms.LockFreeTypes.DataStructures.Treiber;
public class TreiberStack<T>
{
    private Node<T> head;

    public void Push(T value)
    {
        Node<T> newNode = new Node<T>(value);
        while (true)
        {
            Node<T> currentHead = head;
            newNode.Next = currentHead;
            if (Interlocked.CompareExchange(ref head, newNode, currentHead) == currentHead)
            {
                break;
            }
        }
    }

    public bool Pop(out T value)
    {
        while (true)
        {
            Node<T> currentHead = head;
            if (currentHead == null)
            {
                value = default(T);
                return false;
            }
            Node<T> newHead = currentHead.Next;
            if (Interlocked.CompareExchange(ref head, newHead, currentHead) == currentHead)
            {
                value = currentHead.Value;
                return true;
            }
        }
    }
}
