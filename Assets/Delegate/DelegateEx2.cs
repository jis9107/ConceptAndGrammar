using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateEx2 : MonoBehaviour
{
    public delegate void TestDelegate(); // 델리게이트 타입 선언 
    
    TestDelegate testDelegate; // 객체 정의

    /*void Do(TestDelegate del)
    { 
        // 두 개 모두 똑같은 실행법이다.
        del();
        del.Invoke();
    }
    
    void TargetFunction()
    {
        // 여기 있는 코드를 사용하고 싶다.
        Debug.Log("TargetFunction");
    }

    void Start()
    {
        testDelegate = TargetFunction; // 함수 참조
        Do(testDelegate);
    }*/

    TestDelegate Do()
    {
        return testDelegate = TargetFunction;
    }

    void TargetFunction()
    {
        Debug.Log("TargetFunction");
    }
    
    void Start()
    {
        TestDelegate result = Do();
        result.Invoke();
    }
}
