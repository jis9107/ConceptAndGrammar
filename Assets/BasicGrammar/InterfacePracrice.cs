using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfacePracrice : MonoBehaviour
{
    public interface IOnDamage
    {
        public void OnDamage();
    }

    public interface IMove
    {
        public void Move();
    }

    public abstract class Monster
    {
        public abstract void Attack();
    }

    public class Orc : Monster, IMove, IOnDamage
    {
        public override void Attack() { }
        
        // IMove로 상속 받은 Move 메소드
        public void Move() { }

        // IOnDamage로 상속 받은 OnDamage 메소드
        public void OnDamage()
        {
            Debug.Log("Orc : OnDamage");
        }
    }

    public class Goblin : Monster, IMove, IOnDamage
    {
        public override void Attack() { }
        
        public void Move() { }

        public void OnDamage()
        {
            Debug.Log("Goblin : OnDamage");
        }
    }

    public class Tiger : IMove, IOnDamage
    {
        public void Move() { }

        public void OnDamage()
        {
            Debug.Log("Tiger : OnDamage");
        }
    }
    
    public class Lion : IMove, IOnDamage
    {
        public void Move() { }

        public void OnDamage()
        {
            Debug.Log("Lion : OnDamage");
        }
    }
 

    public class Player
    {
        public void Attack(IOnDamage target)
        {
            target.OnDamage();
        }
    }

    public void Start()
    {
        Player player = new Player();
        Orc orc = new Orc();
        Goblin goblin = new Goblin();
        Tiger tiger = new Tiger();
        Lion Lion = new Lion();
        
        List<IOnDamage> targets = new List<IOnDamage>();
        
        targets.Add(orc);
        targets.Add(goblin);
        targets.Add(tiger);
        targets.Add(Lion);
        
        foreach (var target in targets)
        {
            player.Attack(target);
        }
    }
}
