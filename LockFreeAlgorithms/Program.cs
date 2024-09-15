using LockFreeAlgorithms.LockFreeTypes.Atomic_Read_Modify_Write;
using LockFreeAlgorithms.LockFreeTypes.CompareAndSwap;
using LockFreeAlgorithms.LockFreeTypes.DataStructures.MichaelScott;
using LockFreeAlgorithms.LockFreeTypes.DataStructures.Treiber;
using LockFreeAlgorithms.LockFreeTypes.MemoryOrdering;
using LockFreeAlgorithms.LockFreeTypes.ObstructionFree;
using LockFreeAlgorithms.LockFreeTypes.WaitFree;

namespace LockFreeAlgorithms;

internal class Program
{
    static void Main(string[] args)
    {

        #region AtomicReadModifyWrite
        AtomicReadModifyWriteUsage.Use();
        #endregion

        #region CAS
        CASOperationsUsage.Use();
        #endregion

        #region Lock-free structures
        MichaelScottQueueUsage.Use();
        TreiberStackUsage.Use();
        #endregion

        #region MemoryOrderingOperations
        MemoryOrderingOperationsUsage.Use();
        #endregion

        #region ObstructionFreeStack
        ObstructionFreeStackUsage.Use();
        #endregion

        #region WaitFree
        WaitFreeQueueUsage.Use();
        #endregion
    }
}
