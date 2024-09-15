# Concurrent Lock-Free Algorithms in C#

This repository contains various examples of concurrent algorithms implemented in C#. Each example demonstrates a different type of lock-free or wait-free algorithm.

## Table of Contents

•  [Atomic Read-Modify-Write Operations](https://github.com/alisadri1993/LockFreeAlgorithms/tree/master/LockFreeAlgorithms/LockFreeTypes/Atomic-Read-Modify-Write)

•  [Compare-And-Swap (CAS) Loop](https://github.com/alisadri1993/LockFreeAlgorithms/tree/master/LockFreeAlgorithms/LockFreeTypes/CompareAndSwap)

•  [Michael-Scott Queue](https://github.com/alisadri1993/LockFreeAlgorithms/tree/master/LockFreeAlgorithms/LockFreeTypes/DataStructures/MichaelScott)

•  [Treiber Stack](https://github.com/alisadri1993/LockFreeAlgorithms/tree/master/LockFreeAlgorithms/LockFreeTypes/DataStructures/Treiber)

•  [Memory Ordering](https://github.com/alisadri1993/LockFreeAlgorithms/tree/master/LockFreeAlgorithms/LockFreeTypes/MemoryOrdering)

•  [Obstruction-Free Algorithm](https://github.com/alisadri1993/LockFreeAlgorithms/tree/master/LockFreeAlgorithms/LockFreeTypes/ObstructionFree)

•  [Wait-Free Algorithm](https://github.com/alisadri1993/LockFreeAlgorithms/tree/master/LockFreeAlgorithms/LockFreeTypes/WaitFree)


## Atomic Read-Modify-Write Operations

This example demonstrates how to use atomic read-modify-write operations using the `Interlocked` class in C#.

## Compare-And-Swap (CAS) Loop

This example demonstrates a compare-and-swap (CAS) loop using the `Interlocked.CompareExchange` method.

## Michael-Scott Queue

This example demonstrates a lock-free queue using the Michael-Scott algorithm.

## Treiber Stack

This example demonstrates a lock-free stack using the Treiber algorithm.

## Memory Ordering

This example demonstrates memory ordering using the `volatile` keyword and `Thread.MemoryBarrier`.

## Obstruction-Free Algorithm

This example demonstrates an obstruction-free stack.

## Wait-Free Algorithm

This example demonstrates a wait-free queue.
