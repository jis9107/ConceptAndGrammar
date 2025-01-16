using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TransitionCondition
{
    public string fromState;
    public string toState;
    public string conditionMethod;
}

[Serializable]
public class FSMConfiguration
{
    public string initalState; // 초기화
    public List<string> states; // 상태들
    public List<TransitionCondition> transitions; // 변경되야 할 상태들의 조건
}

public abstract class StateBase
{
    protected FSMSystem fsm;
    protected MonsterController monster;

    public virtual void OnEnter() { }

    public virtual void OnExit() { }

    public virtual void OnUpdate() { }
    
    public void Initialize(FSMSystem fsm, MonsterController monster)
    {
        this.fsm = fsm;
        this.monster = monster;
    }
}

public class IdleState : StateBase
{
    
}

public class ChaseState : StateBase
{
    
}

public class AttackState : StateBase
{
    
}

public class FSMSystem : MonoBehaviour
{
    private Dictionary<string, StateBase> states = new();
    private StateBase currentState;
    private FSMConfiguration configuration;

    public void Initialize(string configName, MonsterController monster)
    {
        TextAsset loadedText = Resources.Load<TextAsset>(configName); // fsm 하나당 Json 하나를 갖는다. 예외 처리 해줘야 함
        FSMConfiguration configuration = JsonUtility.FromJson<FSMConfiguration>(loadedText.text);

        foreach (string stateName in configuration.states)
        {
            Type stateType = Type.GetType(stateName);
            StateBase state = Activator.CreateInstance(stateType) as StateBase;
            state.Initialize(this, monster);
            states[stateName] = state;
            
        }
    }

    private void CheckTransitions() // 상태 검사
    {
        foreach (var transition in configuration.transitions)
        {
            if (transition.fromState == currentState.GetType().Name)
            {
                if (CheckCondition(transition.conditionMethod))
                {
                    
                }
            }
        }
    }

    private bool CheckCondition(string methodName)
    {
        return true;
    }

    private void ChangeState(string newStateName)
    {
        if (currentState != null)
        {
            currentState.OnExit();
        }

        if (states.TryGetValue(newStateName, out StateBase state))
        {
            currentState = state;
            currentState.OnEnter();
        }
    }

    public string GetCurrentStateName()
    {
        return currentState.GetType().Name ?? string.Empty;
    }
}

[RequireComponent(typeof(FSMSystem))]
public class MonsterController : MonoBehaviour
{
    public string fsmType = "";
    private FSMSystem fsm;

    [SerializeField] float detectionRange = 10f;
    [SerializeField] private float attackRange = 2f;
    [SerializeField] private float maxHp = 100f;
    
    private float currentHp;


    void Start()
    {
        currentHp = maxHp;
    }
}
