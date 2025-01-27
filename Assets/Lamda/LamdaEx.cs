using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LamdaEx : MonoBehaviour
{
    delegate void TestDel(); // 반환 타입이 없고 매개 변수가 없는 델리게이트 선언
    
    delegate int TestDel2(int num1, int num2); // 반환 타입 : int형, 매개 변수 : int, int 델리게이트 선언
    
    void Start()
    {
        TestDel del;
        del = () => Debug.Log("TestFunc");
        
        del.Invoke();
        
        TestDel2 del2;
        del2 = (int num1, int num2) => num1 + num2;
        int result = del2.Invoke(3, 5);
        Debug.Log(result);
    }
}