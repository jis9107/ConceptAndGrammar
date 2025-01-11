using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEx3 : MonoBehaviour
{
    void Start()
    {
        // Hashtable
        Hashtable hash = new Hashtable();
        hash["Book"] = "책";
        hash["Cook"] = "요리";
        hash[1.0f] = 15;
        hash[5092] = true;
        
        Debug.Log(hash["Book"]);
        Debug.Log(hash["Cook"]);
        Debug.Log(hash[1.0f]);
        Debug.Log(hash[5092]);
        
        // Hashtable 일반화
        // Dictionary<T, value>
        Dictionary<string, int> dic = new Dictionary<string, int>();
        dic["하나"] = 1;
        dic["둘"] = 2;
        dic["셋"] = 3;
        
        Debug.Log(dic["하나"]);
        Debug.Log(dic["둘"]);
        Debug.Log(dic["셋"]);
        
        
        
        // stack
        Stack stack = new Stack();
        stack.Push(1); // 1 삽입 -> 현재 stack : 1
        stack.Push(2); // 2 삽입 -> 현재 stack : 1 2
        stack.Push(3); // 3 삽입 -> 현재 stack : 1 2 3

        stack.Pop(); // 제일 마지막에 삽입된(제일 위에 있는) 값 3 추출 -> 현재 stack : 1 2
        stack.Peek(); // 제일 위에 있는 값이 무엇인지 확인 2 -> 현재 stack : 1 2 
        stack.Pop(); // 2 추출 -> 현재 stack : 1
        stack.Pop();
        
        
        // stack 일반화
        // stack<T>
        Stack<int> stack2 = new Stack<int>();
        stack2.Push(1);
        stack2.Push(2);
        stack2.Push(3);

        stack2.Pop();
        stack2.Peek();
        stack2.Pop();
        stack2.Pop();
        
        
        // Queue
        Queue queue = new Queue();
        
        queue.Enqueue(1); // 1 삽입 -> 현재 queue : 1
        queue.Enqueue(2); // 2 삽입 -> 현재 queue : 1 2
        queue.Enqueue(3); // 3 삽입 -> 현재 queue : 1 2 3

        queue.Dequeue(); // 제일 처음에 삽입된 값 1 추출 -> 현재 queue : 2 3
        queue.Peek(); // 제일 처음 값 확인 -> 현재 queue : 2 3 
        queue.Dequeue(); // 2 추출 -> 현재 queue : 3
        
        // Queue 일반화
        // Queue<T>
        Queue<int> queue2 = new Queue<int>();
        
        queue2.Enqueue(1); // 1 삽입 -> 현재 queue : 1
        queue2.Enqueue(2); // 2 삽입 -> 현재 queue : 1 2
        queue2.Enqueue(3); // 3 삽입 -> 현재 queue : 1 2 3
        
        queue2.Dequeue(); // 제일 처음에 삽입된 값 1 추출 -> 현재 queue : 2 3
        queue2.Peek(); // 제일 처음 값 확인 -> 현재 queue : 2 3 
        queue2.Dequeue(); // 2 추출 -> 현재 queue : 3
    }
}
