using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateEx : MonoBehaviour
{
    /*// 델리게이트 기본적인 사용 법
    public delegate void MyDelegate(); // 델리게이트 타입 정의
    public MyDelegate myDelegate; // 선언한 델리게이트의 변수(객체) 선언

    public void Test()
    {
        Debug.Log("Test 함수 실행");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        myDelegate = new MyDelegate(Test); // C# 1.0 버전 사용법
        myDelegate = Test; // C# 2.0 버전 사용법
        
        myDelegate(); // 사용
    }*/
    
    public delegate int IntDelegate(int num1, int num2);

    public IntDelegate intDelegate;

    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Sub(int num1, int num2)
    {
        return num1 - num2;
    }

    void Start()
    {
        intDelegate = Add;
        Debug.Log(intDelegate(10, 5));
        intDelegate = Sub;
        Debug.Log(intDelegate(10, 5));
    }

}
