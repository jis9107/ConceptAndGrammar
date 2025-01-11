using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEx : MonoBehaviour
{
    // 형식 매개변수 -> 제네릭 자료형을 나타낸다.
    // 오브젝트를 T로 대체한다.
    // 이점이 뭘까?
    // 플레이가 되고 실질적인 코드가 돌아갈 때 우리가 필요한 자료형을 매개변수로 넣어주면
    // 그 자료형으로 컴파일이 된다.
    public void Copy<T>(T[] source, T[] target)
    {
        for (int i = 0; i < source.Length; i++)
        {
            target[i] = source[i];
        }
    }
    
}

