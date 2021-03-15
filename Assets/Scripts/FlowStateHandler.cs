using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowStateHandler : MonoBehaviour
{
    public static FlowStateHandler instance;
    public bool IsShuttingDown
    {
        get; private set;
    }
    [SerializeField]
    private FlowStateData[] stateOrder;

    public int CurrentState
    {
        get; private set;
    }

    public FlowStateData CurrentStateData
    {
        get; private set;
    }


    void Awake()
    {
        instance = this;
        IsShuttingDown = false;

        
    }

    private void Start()
    {
        SetState(0);
    }

    private void OnDestroy()
    {
        IsShuttingDown = true;
    }

    private void OnApplicationQuit()
    {
        IsShuttingDown = true;
    }
    public void NextState(float delay= 1f)
    {
        StartCoroutine(TimedNextState(delay));
    }
    private IEnumerator TimedNextState(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (CurrentState + 1 < stateOrder.Length)
        {
            SetState(CurrentState + 1);
        }
        else
        {
            //To Do: End Flow
        }
    }
    private void SetState(int state)
    {
        if(state==CurrentState && CurrentStateData != null)
        {
            return;
        }
        if (CurrentStateData != null)
        {
            SetGameObjectsActive(CurrentStateData.deactivateOnStateEnd, false);
        }
        CurrentState = state;
        CurrentStateData = stateOrder[state];

        SetGameObjectsActive(CurrentStateData.activateOnStateStart, true);
    }
    private void SetGameObjectsActive(GameObject[]gameObjects, bool active = true)
    {
        foreach(GameObject go in gameObjects)
        {
            go.SetActive(active);
            if (go.GetComponent<IFlowstate>() != null)
            {
                if (active)
                {
                    go.GetComponent<IFlowstate>().StartState();

                }
                else
                {
                    go.GetComponent<IFlowstate>().EndState();
                }
            }
        }
    }
}
[System.Serializable]
public class FlowStateData
{
    public string stepName = "";

    [SerializeField]
    public GameObject[] activateOnStateStart;

    [SerializeField]
    public GameObject[] deactivateOnStateEnd;


}