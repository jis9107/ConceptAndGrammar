using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateEx4 : MonoBehaviour
{
    // 콜백(CallBack)
    // 함수를 호출하는 것을 Call
    // 함수를 나중에 (Back) 호출한다. (Call)의 의미로 이해하면 쉽다.

    class Player
    {
        public void Attack()
        {
            Debug.Log("Attack");
        }
    }

    void Start()
    {
        Player player = new Player();
        player.Attack();
    }
}
