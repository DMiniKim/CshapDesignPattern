using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class TimeManager : MonoBehaviour
{
    [SerializeField] Text timeText;

    [SerializeField] float time;
    [SerializeField] int minute;
    [SerializeField] int second;
    [SerializeField] int millisecond;

    [SerializeField] bool state = true;

    private void OnEnable()
    {
        EventManager.Subcribe(Condition.START, Execute);
        EventManager.Subcribe(Condition.PAUSE, Pause);
        EventManager.Subcribe(Condition.EXIT, FinishedGame);

    }

    void Execute()
    {
        StartCoroutine(CheckTime());
    }
    void Pause()
    {
        state = false;
    }
    void FinishedGame()
    {
        timeText.text = "Game Over";
    }


    public IEnumerator CheckTime()
    {
        
        while (state)
        {
            if(time <= 0)
            {
                EventManager.Publish(Condition.EXIT);
                yield break;
            }
            time -= Time.deltaTime;

            minute = (int)time / 60;
            second = (int)time % 60;
            millisecond = (int)(time * 100) % 100;

            timeText.text = string.Format("{0:D2} : {1:D2} : {2:D2}", minute, second, millisecond);
            yield return null;
        }

    }


    private void OnDisable()
    {
        EventManager.Unsubcribe(Condition.START, Execute);
        EventManager.Unsubcribe(Condition.PAUSE, Pause);
        EventManager.Unsubcribe(Condition.EXIT, FinishedGame);
    }
}
