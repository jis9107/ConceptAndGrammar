using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{ 
    int _count = 5;
    private void Start()
    {
    }

    public void SetCountDown(int value)
    {
        _count -= value;
        Debug.Log("몬스터가 죽었습니다" + _count);
    }
}
