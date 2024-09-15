namespace LockFreeAlgorithms.LockFreeTypes.CompareAndSwap;
public static class CASOperationsUsage
{
    public static void Use()
    {
        int sharedValue = 0;
        Thread[] threads = new Thread[10];

        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(() => CASOperations.CompareAndSwap(ref sharedValue));
            threads[i].Start();
        }

        foreach (Thread t in threads)
        {
            t.Join();
        }

        Console.WriteLine("Final value of sharedValue: " + sharedValue);
    }
}
