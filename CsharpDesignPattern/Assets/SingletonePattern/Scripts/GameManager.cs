using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] bool state;
    public bool State { get { return state; } }

    private static GameManager instance;
    public static GameManager Instance { get { return instance; } } 
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
        }
    }
    public void ChangeState()
    {
        state = !state;
    }
    
    
}