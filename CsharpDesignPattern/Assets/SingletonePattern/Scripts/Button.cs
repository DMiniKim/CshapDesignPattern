using UnityEngine;
using UnityEngine.UI;
public class PauseButton : MonoBehaviour
{
    GameManager gameManager;
    Button button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(gameManager.ChangeState);
    }

    private void Update()
    {
            
    }
    

}
