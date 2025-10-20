using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] bool state;
    private static GameManager instance;
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