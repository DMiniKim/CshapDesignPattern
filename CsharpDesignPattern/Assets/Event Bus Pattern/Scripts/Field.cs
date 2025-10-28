using Unity.VisualScripting;
using UnityEngine;

public class Field : MonoBehaviour
{
    Animator animator;


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {

    }
    private void OnEnable()
    {
        EventManager.Subcribe(Condition.START, AnimationAble);
        EventManager.Subcribe(Condition.PAUSE, AnimationDisable);
        EventManager.Subcribe(Condition.EXIT, EndGame);
    }
    private void OnDisable()
    {
        EventManager.Unsubcribe(Condition.START, AnimationAble);
        EventManager.Unsubcribe(Condition.PAUSE, AnimationDisable);
        EventManager.Unsubcribe(Condition.EXIT, EndGame);

    }

    void AnimationDisable()
    {
        animator.enabled = false;
    }
    void AnimationAble()
    {
        animator.enabled = true;
    }
    void EndGame()
    {
        Destroy(gameObject);
    }

}
