using System.Runtime.InteropServices;
using System;

public abstract class LibDefine 
{
    [DllImport("Basic")]
    public static extern int add(int a, int b);

    [DllImport("Marshal")]
    public static extern int unmanaged_add(IntPtr ptr, int length);

    [DllImport("Marshal")]
    public static extern int managed_add(out IntPtr ptr, int length);
}
