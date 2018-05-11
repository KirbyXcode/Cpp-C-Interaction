using System.Runtime.InteropServices;
using UnityEngine;

public class Interaction : MonoBehaviour 
{
    //[DllImport("__Internal")]
    [DllImport("Cpp_Test")]
    //[DllImport("Cpp_Test.dll")]
    private static extern int Add(int a, int b);

    private void Start()
    {
        int a = Add(10, 14);
        print(a);
    }
}
