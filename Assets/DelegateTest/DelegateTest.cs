using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{
    public delegate void MyDelegate();
    public static MyDelegate myDelegate;
    
    // Start is called before the first frame update
    void Start()
    {
        myDelegate += TakeDamage;
        myDelegate += SetCount;
        
        myDelegate -= SetCount;

        myDelegate();
    }

    void TakeDamage()
    {
        Debug.Log("데미지를 입었습니다.");
    }

    void SetCount()
    {
        Debug.Log("카운트가 줄었습니다.");
    }

}
