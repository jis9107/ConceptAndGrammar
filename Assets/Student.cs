using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Student : MonoBehaviour
{
    Human human = new Human();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnDestroy()
    {
        human.SetCountDown(-1);
    }
}
