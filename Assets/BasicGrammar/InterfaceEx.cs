using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceEx : MonoBehaviour
{

    // 인터페이스
    // interface로 생성하고 인터페이스 이름에는 맨 앞에 I를 붙인다.(규칙)
    // 이벤트, 인덱서, 프로퍼티, 메소드 (자주 사용하는 것은 프로퍼티와 메소드)
    // 추상 클래스 단점 보완 (다중 상속 가능)
    // 인스턴스(객체) 생성 불가능
    public interface IShout
    {
        public void Shout(); // 인터페이스 메소드는 상속을 받는다면 구현해줘야 한다(강제성)
    }

    public interface IMove
    {
        public void Move();
    }

    public class Lion : IShout
    {
        public void Shout() // Shout() 재정의
        {
            // Lion의 Shout() 구현
        }
    }

    public class Tiger : IShout, IMove // 다중 상속 가능
    {
        public void Shout()
        {
            // Tiger의 Shout() 구현
        }

        public void Move()
        {
            // Tiger의 Move() 구현
        }
    }
    
}
