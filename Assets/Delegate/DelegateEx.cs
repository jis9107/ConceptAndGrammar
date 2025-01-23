using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateEx : MonoBehaviour
{
    public delegate void VoidDelegate(); // 델리게이트 타입 정의
    public VoidDelegate voidDelegate; // 선언한 델리게이트의 변수(객체) 선언
    
    public delegate void IntDelegate(int num);
    public IntDelegate intDelegate;

    public void Test()
    {
        Debug.Log("Test 함수 실행");
    }

    public int TestInt(int num)
    {
        Debug.Log($"{num} + {5} 반환");
        return num + 5;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        voidDelegate = Test;
        intDelegate = num => TestInt(num);
        voidDelegate();
        intDelegate(5);
    }
    
    // 주의 할 점
    // 반환 타입과 매개 변수를 동일하게 맞춰준다.
    
}
