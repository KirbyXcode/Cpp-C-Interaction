using System.Runtime.InteropServices;
using UnityEngine;
using System;

public class Interaction : MonoBehaviour
{
    private void Start()
    {
        Basic();
        TransferUnmanagedMem();
        //TransferManagedMem();
        ApplyUnmanagedMem();
    }

    private void Basic()
    {
        int result = LibDefine.add(10, 14);
        print("Basic: " + result);
    }

    /// <summary>
    /// 托管内存转非托管内存
    /// </summary>
    private void TransferUnmanagedMem()
    {
        int[] intArray = new int[100]; //c# managed memory

        GCHandle intArrayUnmanaged = GCHandle.Alloc(intArray, GCHandleType.Pinned); //Pinned: 固定内存地址 // c# unmanaged memory

        int value = LibDefine.unmanaged_add(intArrayUnmanaged.AddrOfPinnedObject(), 100);

        print("TransferUnmanagedMem: " + value);

        intArrayUnmanaged.Free(); // return back to managed memory
    }

    /// <summary>
    /// 非托管内存转托管内存
    /// </summary>
    private void TransferManagedMem()
    {
        IntPtr ptr = IntPtr.Zero;

        int value = LibDefine.managed_add(out ptr, 100);

        print("TransferManagedMem: " + value);

        int[] managedIntPtr = new int[100];

        Marshal.Copy(ptr, managedIntPtr, 0, 100 * sizeof(int));

        Marshal.FreeHGlobal(ptr); // release c++ memory
    }

    private void ApplyUnmanagedMem()
    {
        IntPtr ptr = Marshal.AllocHGlobal(100 * sizeof(int));

        int value = LibDefine.unmanaged_add(ptr, 100);

        print("ApplyUnmanagedMem: " + value);

        Marshal.FreeHGlobal(ptr);
    }
}