using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeCasting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //TypeCast1();
        //TypeCast2();
        TypeCast4();
    }

    void TypeCast1()
    {
        sbyte a = 127;
        Debug.Log(a);

        int b = (int)a;
        Debug.Log(b);

        int c = 128;
        Debug.Log(c);
        
        sbyte d = (sbyte)c;
        Debug.Log(d);
    }
    
    void TypeCast2()
    {
        int a = 200;
        Debug.Log(a);

        uint b = (uint)a;
        Debug.Log(b);

        int c = -30;
        Debug.Log(c);
        
        uint d = (uint)c;
        Debug.Log(d);
    }

    void TypeCast3()
    {
        float a = 0.9f;
        int b = (int)a;
        Debug.Log(b);

        float c = 1.1f;
        int d = (int)c;
        Debug.Log(d);
    }

    void TypeCast4()
    {
        int a = int.Parse("12345");
        Debug.Log($"a : {a}");
        float b = float.Parse("123.45");
        Debug.Log($"b : {b}");

        int c = 13245;
        string d = c.ToString();
        Debug.Log($"d : {d}");

        float e = 123.45f;
        string f = e.ToString();
        Debug.Log($"f : {f}");
    }

}
