using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public void UpdateObserver()
    {
        Debug.Log($"Update : {gameObject.name}");
    }
}
