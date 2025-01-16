using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestProperty
{
    public int Num { get; set; }
}
public class PropertyEx : MonoBehaviour
{
    TestProperty testProperty = new TestProperty();

    void Start()
    {
        Debug.Log(testProperty.Num);
        testProperty.Num = 50;
        Debug.Log(testProperty.Num);
    }
}
