using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassEx : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Orc orc = new Orc(); // new라는 키워드를 통해 Orc 클래스로 새로운 객체 orc 인스턴스 생성 new는 새로운 대상을 만들 때 쓰인다.
        Player player = new Player();
        orc.OrcShout();
        Debug.Log("몬스터 남은 체력 : " + orc.hp);
        
        orc.hp = player.Attack(orc.hp);
        Debug.Log("몬스터 남은 쳬력 : " + orc.hp);
    }
    
}

public class Monster
{
    protected int damage = 5;
    public int hp = 100;

    public void Shout()
    {
        Debug.Log("소리 친다");
    }
}

// Monster 클래스의 이동 기능과 대기 기능을 사용할 수 있다.
public class Orc : Monster
{
    public int Attack(int playerHp)
    {
        playerHp -= damage;
        return playerHp;
    }
    
    public void OrcShout()
    {
        base.Shout();
    }
}

class Player
{
    public int hp = 30;
    protected int damage = 5;

    public int Attack(int monsterHp)
    {
        monsterHp -= damage;
        return monsterHp;
    }
}