using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObserverTest : MonoBehaviour
{
    [SerializeField] private Observer obs1;
    [SerializeField] private Observer obs2;
    [SerializeField] private Button button;

    void Start()
    {
        button.onClick.AddListener(() =>
        {
            obs1.UpdateObserver();
            obs2.UpdateObserver();
        });
    }

}
