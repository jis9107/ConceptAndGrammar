using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGrammar : MonoBehaviour
{
    /*
    기초 문법 마무리
    
    1. 기초 문법 용어
    
    1) 예약어
    C# 언어에서 문법을 표현하기 위해 미리 예약된 단어
    sbyte, byte, int, float
    
    
    2) 식별자
    임의로 이름을 지을 수 있는 단어
    변수명, 함수명, 클래스명
    조건
    숫자로 시작할 수 없다.
    특수 기호는 _만 사용 가능
    한글 사용 가능 (비추천)
    예약어 사용 가능 (비추천)
    
    
    3) 리터럴 
    소스코드에 포함된 값
    
    
    4) 상수
    값이 절대 바뀌지 않는 식별자, 한 번 대입하면 다른 값으로 대입 불가능
    const

    */

    void Start()
    {
        IfEx ex = new IfEx();
        ex.If();
    }
}

