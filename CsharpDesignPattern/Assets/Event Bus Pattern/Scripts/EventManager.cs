using System;
using System.Collections.Generic;
using UnityEditor.Rendering.Universal;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
public enum Condition
{
    START,
    PAUSE,
    EXIT,
}

public static class EventManager
{
    private static Dictionary<Condition, Action> eventBus = new();


    public static void Subcribe(Condition state, Action action)
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
    public static void Unsubcribe(Condition state, Action action)
    {
        if (eventBus.ContainsKey(state))
        {
            eventBus[state] -= action;
        }
    }
    public static void Publish(Condition state)
    {
        if (eventBus.TryGetValue(state, out var action))
        {
            action?.Invoke();
        }
    }
}

