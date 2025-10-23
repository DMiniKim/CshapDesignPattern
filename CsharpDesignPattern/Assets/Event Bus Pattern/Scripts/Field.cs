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
        EventManager.Subcribe(State.START, AnimationAble);
        EventManager.Subcribe(State.PAUSE, AnimationDisable);
        EventManager.Subcribe(State.EXIT, EndGame);
    }
    private void OnDisable()
    {
        EventManager.Unsubcribe(State.START, AnimationAble);
        EventManager.Unsubcribe(State.PAUSE, AnimationDisable);
        EventManager.Unsubcribe(State.EXIT, EndGame);

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
