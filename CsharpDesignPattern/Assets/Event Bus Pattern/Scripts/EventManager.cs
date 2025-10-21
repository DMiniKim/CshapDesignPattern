using System;
using System.Collections.Generic;
using UnityEngine;
public enum State
{
    START,
    PAUSE,
    EXIT,
}

public static class EventManager
{
    private static Dictionary<State, Action> eventBus = new();    

}
