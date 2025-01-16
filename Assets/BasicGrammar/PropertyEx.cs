using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestProperty
{
    private int num = 10;

    public int Num
    {
        get { return num; }
        set
        {
            if (value >= 100)
                return;
            num = value;
        }
    }
    
}
public class PropertyEx : MonoBehaviour
{
    TestProperty testProperty = new TestProperty();

    void Start()
    {
        Debug.Log(testProperty.Num);
        testProperty.Num = 200;
        Debug.Log(testProperty.Num);
    }
}
