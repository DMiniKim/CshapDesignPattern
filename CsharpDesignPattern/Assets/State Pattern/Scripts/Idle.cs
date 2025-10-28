using UnityEngine;

public class Idle : MonoBehaviour, State
{
    public void Enter(Character character)
    {
        
    }

    public void Execute(Character character)
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            character.SetState(new Walk());
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            character.SetState(new PickUp());
        }
    }

    public void Exit(Character character)
    { 
    }
}
