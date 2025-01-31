using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncEx : MonoBehaviour
{
    private Func<int> func; 
    // 매개 변수는 없지만 반환 타입이 제너릭
    // 원하는 반환 타입으로 만들 수 있다.

    void Start()
    {
        func = () =>
        {
            int num2 = 2;
            Debug.Log(num2);
            return num2;
        };

        func += () =>
        {
            Debug.Log(int.MinValue);
            return int.MinValue;
        };

        int num1 = func.Invoke();
        
        Debug.Log(num1);
    }
}
