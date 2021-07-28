using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript1 : MonoBehaviour
{
    private int resultNum;
    private int firstNum = 5;
    private int secondNum = 3;
    // Start is called before the first frame update
    void Start()
    {
        Subtor.init();
        resultNum = Subtor.SubCallDiv(firstNum, secondNum);
        Debug.Log("result is " + resultNum);
        resultNum = Divtor.DivCallSub(firstNum, secondNum);
        Debug.Log("result is " + resultNum);
    }

    // Update is called once per frame
    void Update()
    {
       // if (Time.frameCount % 60 == 0)
       // {
       //     resultNum = Mul(firstNum, secondNum);
        //    Debug.Log("result is " + resultNum);
       // }
    }

    int Mul(int a, int b)
    {
        return a * b;
    }
}
