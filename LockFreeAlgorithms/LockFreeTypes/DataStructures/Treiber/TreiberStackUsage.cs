namespace LockFreeAlgorithms.LockFreeTypes.DataStructures.Treiber;
public class TreiberStackUsage
{

    public static void Use()
    {
        TreiberStack<int> stack = new TreiberStack<int>();
        Thread[] threads = new Thread[10];

        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(() =>
            {
                for (int j = 0; j < 100; j++)
                {
                    stack.Push(j);
                }
            });
            threads[i].Start();
        }

        foreach (Thread t in threads)
        {
            t.Join();
        }

        int result;
        while (stack.Pop(out result))
        {
            Console.WriteLine(result);
        }
    }
}
