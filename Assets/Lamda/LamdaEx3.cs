using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamdaEx3 : MonoBehaviour
{
    delegate void TestDel();
    
    void Start()
    {
        TestDel del;

        del = TestFunc;
        del += TestFunc2;
        del -= TestFunc2;

        del.Invoke();
    }

    void TestFunc()
    {
        Debug.Log("Hello");
    }

    void TestFunc2()
    {
        Debug.Log("Hello2");
    }
}