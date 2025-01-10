using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeCasting2 : MonoBehaviour
{
    class Monster // 기반 클래스 (부모 클래스)
    {
        public void Shout()
        {
            Debug.Log("Shout");
        }
    }

    class Orc : Monster // 파생 클래스 (자식 클래스1)
    {
        
    }

    class Troll : Monster // 파생 클래스 (자식 클래스2)
    {
        
    }
    void Start()
    {
        
        
        Monster monster = new Monster();
        Orc orc = new Orc();

        monster = orc as Monster; // monster = (Monster)orc;

        if(monster != null)
            monster.Shout();
    }
}
