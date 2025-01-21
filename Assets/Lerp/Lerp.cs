using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public float yPos;
    
    Vector3 startPos; // 시작 위치 : a
    Vector3 targetPos; // 끝 위치 : b

    float currentTime = 0; // a와 b 사이를 선형보간하는 t
    float moveTime = 5.0f; // 
    float colorChangeTime = 10.0f; // 색이 변하는 시간

    private Material mat;

    void Start()
    {
        startPos = transform.position;
        targetPos = startPos + Vector3.up * yPos;
        
        mat = GetComponent<Renderer>().material;
    }
    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        
        transform.position = Vector3.Lerp(startPos, targetPos, currentTime / moveTime); // Vector3.Lerp(a, b, t)
        mat.color = Color.Lerp(mat.color, Color.yellow, currentTime / colorChangeTime);
    }
}
