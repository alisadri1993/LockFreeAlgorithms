namespace LockFreeAlgorithms.LockFreeTypes.CompareAndSwap;
public static class CASOperations
{
    /// <summary>
    ///  In this version:
    ///  The CASOperations class contains the CompareAndSwap method.
    ///  The Program class handles the creation and management of threads, and it uses the CASOperations class to perform the CAS loop.
    /// </summary>
    /// <param name="location"></param>
    public static void CompareAndSwap(ref int location)
    {
        for (int i = 0; i < 1000; i++)
        {
            int initialValue, newValue;
            do
            {
                initialValue = location;
                newValue = initialValue + 1;
            }
            while (Interlocked.CompareExchange(ref location, newValue, initialValue) != initialValue);
        }
    }
}
