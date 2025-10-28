using UnityEngine;

public class PickUp : MonoBehaviour ,State
{
    
    public void Enter(Character character)
    {
        character.animator.SetTrigger("Pick Up");
    }

    public void Execute(Character character)
    {
        AnimatorStateInfo animatorStateInfo = character.animator.GetCurrentAnimatorStateInfo(0);

        if (animatorStateInfo.IsName("Pick Up") && animatorStateInfo.normalizedTime <1.0f || character.animator.IsInTransition(0))
        {
            character.SetState(new Idle());
        }        
    }

    public void Exit(Character character)
    {
        
    }


}
