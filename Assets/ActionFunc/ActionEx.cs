using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionEx : MonoBehaviour
{
    private Action action;
    
    Action<int> actionInt;
    Action<int, int> actionInt2;
    Action<string> actionString;

    void Start()
    {
        action = () => Debug.Log("Action1");
        action += () => Debug.Log("Action2");
        action += () => Debug.Log("Action3");
        action.Invoke();
        
        actionInt = Test1;
        actionInt.Invoke(1);

        actionInt2 = Test2;
        actionInt2.Invoke(1, 3);

        actionString = Test3;
        actionString.Invoke("Test");

    }

    private void Test3(string str)
    {
        Debug.Log(str);
    }

    void Test1(int a)
    {
        Debug.Log(a);
    }

    void Test2(int a, int b)
    {
        Debug.Log(a+b);
    }
}
