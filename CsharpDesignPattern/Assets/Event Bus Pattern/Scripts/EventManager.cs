using System;
using System.Collections.Generic;
using UnityEditor.Rendering.Universal;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
public enum State
{
    START,
    PAUSE,
    EXIT,
}

public static class EventManager
{
    private static Dictionary<State, Action> eventBus = new();


    public static void Subcribe(State state, Action action)
    {
        if (eventBus.ContainsKey(state))   // Ű�� �ִٸ� 
        {
            eventBus[state] += action;
        }
        else                               // Ű�� ���ٸ�
        {
            eventBus.Add(state, action);
        }

    }
    public static void Unsubcribe(State state, Action action)
    {
        if (eventBus.ContainsKey(state))
        {
            eventBus[state] -= action;
        }
    }
    public static void Publish(State state)
    {
        if (eventBus.TryGetValue(state, out var action))
        {
            action?.Invoke();
        }
    }
}

