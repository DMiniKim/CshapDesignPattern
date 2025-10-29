using System.Collections.Generic;
using UnityEngine;

public class CoroutineManager : MonoBehaviour
{
    public static Dictionary<float, WaitForSeconds> dic = new();
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public static WaitForSeconds WaitForSecond(float time)
    {
        if (dic.ContainsKey(time))
        {
            //var temp = dic[time];


        }
        else
        {
            dic.Add(time, new WaitForSeconds(time));
        }
        return dic[time];
    }
}
