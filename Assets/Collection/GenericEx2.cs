using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEx2 : MonoBehaviour
{
    public void Copy(int[] source, int[] target)
    {
        for (int i = 0; i < source.Length; i++)
        {
            target[i] = source[i];
        }
    }

    public void Copy<T>(T[] source, T[] target)
    {
        for (int i = 0; i < source.Length; i++)
        {
            target[i] = source[i];
        }
    }
    void Start()
    {
        int[] sourceArray = { 1, 2, 3, 4, 5 };
        int[] targetArray = new int[sourceArray.Length];
        
        Copy(sourceArray, targetArray);
        Copy<int>(sourceArray, targetArray);
        
        string[] strSourceArray = {"하나", "둘", "셋", "넷", "다섯"};
        string[] strTargetArray = new string[strSourceArray.Length];
        
        Copy(strSourceArray, strTargetArray);
    }
}

