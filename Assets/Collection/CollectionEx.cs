using System.Collections; // ArrayList 사용시 선언해야 한다.
using System.Collections.Generic;
using UnityEngine;

public class CollectionEx : MonoBehaviour
{
    void Start()
    {
        //HashtableEx();
        StackEx();
    }


    void ArrayListEx()
    {
        ArrayList list = new ArrayList();
        list.Add("A");
        list.Add(6);
        list.Add(true);

        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log($"list[{i}]: {list[i]}");
        }
        Debug.Log($"list.Count: {list.Count}");
        Debug.Log("------------------");
        
        list.RemoveAt(0);
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log($"list[{i}]: {list[i]}");
        }
        Debug.Log($"list.Count: {list.Count}");
    }

    void HashtableEx()
    {
        Hashtable hash = new Hashtable();
        hash["Book"] = "책";
        hash["Cook"] = "요리";
        hash[1.0f] = 15;
        hash[5092] = true;
        
        Debug.Log(hash["Book"]);
        Debug.Log(hash["Cook"]);
        Debug.Log(hash[1.0f]);
        Debug.Log(hash[5092]);
    }

    void QueueEx()
    {
        Queue queue = new Queue();
        
        queue.Enqueue(1); // 1 삽입 -> 현재 queue : 1
        queue.Enqueue(2); // 2 삽입 -> 현재 queue : 1 2
        queue.Enqueue(3); // 3 삽입 -> 현재 queue : 1 2 3

        queue.Dequeue(); // 제일 처음에 삽입된 값 1 추출 -> 현재 queue : 2 3
        queue.Peek(); // 제일 처음 값 확인 -> 현재 queue : 2 3 
        queue.Dequeue(); // 2 추출 -> 현재 queue : 3
    }

    void StackEx()
    {
        Stack stack = new Stack();
        stack.Push(1); // 1 삽입 -> 현재 stack : 1
        stack.Push(2); // 2 삽입 -> 현재 stack : 1 2
        stack.Push(3); // 3 삽입 -> 현재 stack : 1 2 3

        stack.Pop(); // 제일 마지막에 삽입된(제일 위에 있는) 값 3 추출 -> 현재 stack : 1 2
        stack.Peek(); // 제일 위에 있는 값이 무엇인지 확인 2 -> 현재 stack : 1 2 
        stack.Pop(); // 2 추출 -> 현재 stack : 1
        stack.Pop();
    }
}
