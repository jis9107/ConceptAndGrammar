using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DelegateTest.myDelegate += PanelOn;
    }

    void PanelOn()
    {
        Debug.Log("패널 온");
    }
}
