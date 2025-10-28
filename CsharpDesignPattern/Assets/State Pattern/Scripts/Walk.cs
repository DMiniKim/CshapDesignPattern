using UnityEngine;

public class Walk : MonoBehaviour, State
{
    [SerializeField] int x;
    [SerializeField] float z;
    public void Enter(Character character)
    {
        
    }

    public void Execute(Character character)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            character.SetState(new PickUp());
        }
        if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 0)
        {
            character.SetState(new Idle());

        }
        int x = (int)Input.GetAxisRaw("Horizontal");

        character.animator.SetInteger("X", x);
    }

    public void Exit(Character character)
    {
        character.animator.SetInteger("X", 0);
    }

}
