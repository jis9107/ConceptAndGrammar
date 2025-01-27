using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateChainEx : MonoBehaviour
{
    // 델리게이트 체인 (Delegate Chain)
    // 하나의 델리게이트가 여러 함수를 동시에 참조할 수 있다.
    
    private delegate void TestDelegate();
    
    TestDelegate testDelegate;

    void Chain1() { Debug.Log("Chain1"); }
    void Chain2() { Debug.Log("Chain2"); }
    void Chain3() { Debug.Log("Chain3"); }

    
    void Start()
    {
        testDelegate?.Invoke();
    }
}
