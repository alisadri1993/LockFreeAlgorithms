namespace LockFreeAlgorithms.LockFreeTypes.MemoryOrdering;
public static class MemoryOrderingOperations
{
    private static volatile int _data;
    private static volatile bool _initialized;

    public static void Writer()
    {
        _data = 42;
        Thread.MemoryBarrier(); // Ensure _data is written before _initialized
        _initialized = true;
    }

    public static void Reader()
    {
        while (!_initialized)
        {
            Thread.Sleep(1); // Wait until _initialized is true
        }
        Thread.MemoryBarrier(); // Ensure _initialized is read before _data
        Console.WriteLine("Data: " + _data);
    }
}

