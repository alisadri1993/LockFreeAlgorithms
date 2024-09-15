using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockFreeAlgorithms.LockFreeTypes.Atomic_Read_Modify_Write;
internal class AtomicReadModifyWriteUsage
{
    public static void Use()
    {
        Thread[] threads = new Thread[10];

        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(AtomicOperations.IncrementSharedValue);
            threads[i].Start();
        }

        foreach (Thread t in threads)
        {
            t.Join();
        }

        Console.WriteLine("Final value of sharedValue: " + AtomicOperations.SharedValue);
    }
}
