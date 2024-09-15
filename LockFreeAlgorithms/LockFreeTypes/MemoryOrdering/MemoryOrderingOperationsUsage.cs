namespace LockFreeAlgorithms.LockFreeTypes.MemoryOrdering;
public  class MemoryOrderingOperationsUsage
{
    public static void Use()
    {
        Thread writerThread = new Thread(MemoryOrderingOperations.Writer);
        Thread readerThread = new Thread(MemoryOrderingOperations.Reader);

        writerThread.Start();
        readerThread.Start();

        writerThread.Join();
        readerThread.Join();
    }
}

