using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncEx2 : MonoBehaviour
{
    void Start()
    {
        Func<int> func1 = () =>
        {
            return 1;
        };

        Func<int, int> func2 = (int num) =>
        {
            return num;
        };
        
        Func<int, int, string> func3 = Test;
        // Func는 마지막이 반환 타입
        // func3는 int형 매개 변수가 2개 이고, 반환 타입이 string이다.
        
    }

    string Test(int a, int b)
    {
        return (a + b).ToString();
    }
}
