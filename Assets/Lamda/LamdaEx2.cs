using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamdaEx2 : MonoBehaviour
{
    delegate int TestDel(int num1, int num2);
    
    void Start()
    {
        TestDel del;
        del = (int num1, int num2) =>
        {
            Debug.Log("문 형식 람다식의 사용 예시");
            Debug.Log("num1 + num2");
            return num1 + num2;
        };
        Debug.Log(del.Invoke(3, 5));

    }
}
