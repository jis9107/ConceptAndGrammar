using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test
{
    public int a;
    protected int b;
    private int c;
}

public class Test2 : Test
{
}

public class encapsulation : MonoBehaviour
{
    private Test test;
    void Start()
    {
        test.a = 1;
    }
}
