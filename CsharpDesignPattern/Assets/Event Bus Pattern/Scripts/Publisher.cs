using UnityEngine;

public class Publisher : MonoBehaviour
{
    
    void Start()
    {
        EventManager.Publish(State.START);
    }
    public void Pause()
    {
        EventManager.Publish(State.PAUSE);
    }

}
