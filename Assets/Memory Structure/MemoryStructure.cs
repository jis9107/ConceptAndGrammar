using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestOrc
{
    public float damage;
    public int health;
    
    public void Move()
    {
        Debug.Log("이동");
    }
}

public class MemoryStructure : MonoBehaviour
{
    public float baseDamage = 3f;
    
    public Transform position;
    public Vector3 direction;
    
    void Start()
    {
        Test();
    }

    void Test()
    {
        int heath = 100;
        float damage = 10f;
        
        TestOrc orc1 = new TestOrc();
        TestOrc orc2 = new TestOrc();
        TestOrc orc3 = new TestOrc();

    }
    void Test2()
    {

    }
    


}
