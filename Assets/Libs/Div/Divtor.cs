using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Divtor
{
    public delegate int SubDelegate(int a, int b);
    public static SubDelegate subDelegate = null;
    
    public static int Div(int a, int b)
    {
        if (b == 0)
        {
            return 0;
        }
        return a / b;
    }

    public static int DivCallSub(int a, int b)
    {
        if (subDelegate != null)
        {
            return subDelegate(a, b);
        }
        return 0;
    }
}
