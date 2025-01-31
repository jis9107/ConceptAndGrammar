using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UnityActionEx : MonoBehaviour
{
    UnityAction unityAction;

    UnityAction<int> unityActionInt; 
    // 매개변수가 하나가 있는 델리게이트
    // 매개변수를 4개까지 사용가능
    
    public Button button;

    void Start()
    {
        unityAction = () => Debug.Log("button1");
        
        button.onClick.AddListener(unityAction);
        button.onClick.AddListener(() => Debug.Log("button2"));

    }
}

