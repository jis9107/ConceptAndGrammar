using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateEx5 : MonoBehaviour
{
    class Player
    {
        public enum Buff
        {
            None,
            Buff1,
            Buff2
        }

        public Buff buff;

        public void BuffCheck(Buff _buff)
        {
            if (_buff == Buff.None)
                NoneBuff();
        
            else if (_buff == Buff.Buff1)
                Buff1();
        
            else if (_buff == Buff.Buff2)
                Buff2();
        }
        public void Attack(Buff _buff)
        {
            BuffCheck(_buff);
            Debug.Log("Attack"); // 적을 공격하는 함수
        }

        private void Buff1() { Debug.Log("Buff 1"); } // 버프1 계산 함수
        private void Buff2() { Debug.Log("Buff 2"); } // 버프2 계산 함수
        private void NoneBuff() { Debug.Log("None Buff"); } // 버프 없을 때 
    }
    
    void Start()
    {
        Player player = new Player();
        player.buff = Player.Buff.Buff1;
        player.Attack(player.buff);
    }
    // 의존적인 코드
}
