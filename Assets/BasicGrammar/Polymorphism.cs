using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polymorphism : MonoBehaviour
{
    public class Monster
    {
        public virtual void Attack()
        {
        }
    }

    public class MeleeMonster : Monster
    {
        public override void Attack()
        {
            Debug.Log("Melee Attack");
        }
    }

    public class RangeMonster : Monster
    {
        public override void Attack()
        {
            Debug.Log("Range Attack");
        }
    }

    public class Player
    {
        public void OnDamage(Monster monster)
        {
            monster.Attack();
        }
    }

    private void Start()
    {
        Monster meleeMonster = new MeleeMonster();
        Monster rangeMonster = new RangeMonster();
        
        List<Monster> monsters = new List<Monster>();
        
        monsters.Add(meleeMonster);
        monsters.Add(rangeMonster);
        
        Player player = new Player();
        
        foreach (var mob in monsters)
        {
            player.OnDamage(mob);
        }
        
    }
}
