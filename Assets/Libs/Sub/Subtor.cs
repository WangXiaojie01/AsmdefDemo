using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Subtor
{
    public static void init()
    {
        Divtor.subDelegate = Sub;
    }
    public static int Sub(int a, int b)
    {
        return a - b;
    }
    public static int SubCallDiv(int a, int b)
    {
//#if UINTY_ANDROID
        return Divtor.Div(a, b);
//#else
 //       return 0;
//#endif
    }
}
