using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateEx3 : MonoBehaviour
{
    public delegate void TestDelegate();
    
    TestDelegate testDelegate;

    void Start()
    {
        TestDelegate result = Do();
        result.Invoke();
    }

    TestDelegate Do()
    {
        return testDelegate = TargetFunction;
    }

    void TargetFunction()
    {
        Debug.Log("TargetFunction");
    }
}
