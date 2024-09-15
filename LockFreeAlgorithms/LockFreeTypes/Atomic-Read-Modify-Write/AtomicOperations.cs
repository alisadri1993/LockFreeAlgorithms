namespace LockFreeAlgorithms.LockFreeTypes.Atomic_Read_Modify_Write;
public static class AtomicOperations
{
    private static int sharedValue = 0;

    public static int SharedValue => sharedValue;

    public static void IncrementSharedValue()
    {
        for (int i = 0; i < 1000; i++)
        {
            Interlocked.Increment(ref sharedValue);
        }
    }
}

