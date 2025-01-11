using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEx2 : MonoBehaviour
{
    public void Copy<T>(T[] source, T[] target)
    {
        for (int i = 0; i < source.Length; i++)
        {
            Debug.Log(target[i] = source[i]);
        }
    }
    /*void Start()
    {
        int[] sourceArray = { 1, 2, 3, 4, 5 };
        int[] targetArray = new int[sourceArray.Length];
        
        Copy<int>(sourceArray, targetArray);
        
        string[] strSourceArray = {"하나", "둘", "셋", "넷", "다섯"};
        string[] strTargetArray = new string[strSourceArray.Length];
        
        Copy<string>(strSourceArray, strTargetArray);
    }*/

    public class ReturnInt
    {
        private int value;

        public int Return()
        {
            return value;
        }
    }

    public class ReturnFloat
    {
        private float value;

        public float Return()
        {
            return value;
        }
    }

    public class ReturnGeneric<T> where T : class
    {
        private T value;

        public T Return()
        {
            return value;
        }
    }

    void Start()
    {
        /*ReturnGeneric<int> intGeneric = new ReturnGeneric<int>();
        ReturnGeneric<float> floatGeneric = new ReturnGeneric<float>();*/
        
        ReturnGeneric<ReturnFloat> classGeneric = new ReturnGeneric<ReturnFloat>();
    }
}

