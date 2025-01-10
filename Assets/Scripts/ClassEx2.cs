using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassEx2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Skeleton skeleton1 = new Skeleton();
        Skeleton skeleton2 = new Skeleton();
        

        skeleton1.damage = 5;
        skeleton2.damage = 10;

        skeleton1 = skeleton2; // skeleton1을 skeleton2로 만들어주는 게 아니라 skeleton2에 있는 참조 값을 skeleton1로 넘겨준다.
        skeleton1.defence = 20;
    }
    
    // 클래스 멤버
    // 클래스에 속한 변수 함수를 클래스의 멤버라고 부른다.
    // 클래스 필드 == 클래스 멤버
    
    // 접근 제한자
    // public : 클래스 외부에서 멤버에 접근 가능
    // private : 클래스 외부에서 멤버에 접근 불가능
    // protected : 클래스 내부와 파생 클래스(상속 클래스)에서만 멤버에 접근 가능
    
}

class Skeleton
{
    public int damage;
    public int defence = 10;

    void Attack()
    {
        // 공격한다.
    }
}
