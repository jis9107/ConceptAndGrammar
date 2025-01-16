using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassEx : MonoBehaviour
{
    void Start()
    {
        Monster goblin; // 클래스를 자료형으로 식별자(변수)선언한다 -> 객체 생성 (빈 껍데기)
        goblin = new Monster(); 
        // 인스턴스(Instance) 생성 -> Monster 클래스의 데이터를 통해 실질적인 goblin 생성
        goblin.name = "Goblin";
        goblin.damage = 15;
        goblin.hp = 50;
        
        goblin.Shout();


        Monster troll;
        troll = new Monster();
        troll.damage = 10;
        troll.hp = 100;
        
        troll.Shout();
        
        
        
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
    public string name;
    public int damage;
    public int hp;

    public void Shout()
    {
        Debug.Log($"{name}의 공격력 : {damage}, 체력 : {hp}");
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