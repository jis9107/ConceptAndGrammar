using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VersionControl;
using UnityEngine;

public class Multipleinheritance : MonoBehaviour
{
    public abstract class Animal
    {
        public abstract void Shout(); // 기존 메서드와 다르게 Shout() 안에 따로 기능을 구현하지 않는다.
    }

    public class Tiger : Animal
    {
        public override void Shout()
        {
            Debug.Log("Tiger Shout");
        }
    }

    public class Lion : Animal
    {
        public override void Shout()
        {
            Debug.Log("Lion Shout");
        }
    }

    public class Liger : Tiger, Lion
    {
        
    }
}
