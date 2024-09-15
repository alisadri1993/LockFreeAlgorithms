namespace LockFreeAlgorithms.LockFreeTypes.WaitFree;
public class WaitFreeQueue<T>
{
    private Node<T> head;
    private Node<T> tail;

    public WaitFreeQueue()
    {
        Node<T> dummy = new Node<T>(default(T));
        head = dummy;
        tail = dummy;
    }

    public void Enqueue(T value)
    {
        Node<T> newNode = new Node<T>(value);
        while (true)
        {
            Node<T> currentTail = tail;
            Node<T> tailNext = currentTail.Next;

            if (currentTail == tail)
            {
                if (tailNext == null)
                {
                    if (Interlocked.CompareExchange(ref currentTail.Next, newNode, null) == null)
                    {
                        Interlocked.CompareExchange(ref tail, newNode, currentTail);
                        return;
                    }
                }
                else
                {
                    Interlocked.CompareExchange(ref tail, tailNext, currentTail);
                }
            }
        }
    }

    public bool Dequeue(out T value)
    {
        while (true)
        {
            Node<T> currentHead = head;
            Node<T> currentTail = tail;
            Node<T> headNext = currentHead.Next;

            if (currentHead == head)
            {
                if (currentHead == currentTail)
                {
                    if (headNext == null)
                    {
                        value = default(T);
                        return false;
                    }
                    Interlocked.CompareExchange(ref tail, headNext, currentTail);
                }
                else
                {
                    value = headNext.Value;
                    if (Interlocked.CompareExchange(ref head, headNext, currentHead) == currentHead)
                    {
                        return true;
                    }
                }
            }
        }
    }
}

