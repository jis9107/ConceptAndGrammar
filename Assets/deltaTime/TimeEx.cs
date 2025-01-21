using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeEx : MonoBehaviour
{
    void Update() // 매 프레임마다 호출 
    {
        transform.position = 
            new Vector3(
                transform.position.x,
                transform.position.y + (1f * Time.deltaTime),
                transform.position.z);
    }
    
    
    // 만약 1초에 100프레임의 속도를 가지고 있는 PC의 경우
    // Time.deltaTime = 0.01f
    
    // y축으로 1만큼
    
    // 만약 1초에 200프레임의 속도를 가지고 있는 PC의 경우 
    // Time.deltaTie = 0.005f
    
    // y축으로 1만큼
}
