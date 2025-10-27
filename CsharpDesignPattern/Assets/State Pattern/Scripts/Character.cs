using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    [SerializeField] int x;
    [SerializeField] float z;
    [SerializeField] Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Pickup();
        }
        Walk();
    }
    public void Walk()
    {
        x = (int)Input.GetAxisRaw("Horizontal");
        animator.SetInteger("X", x);
        z = Input.GetAxis("Vertical");
    }
    public void Pickup()
    {       
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Pick up") ||
            animator.IsInTransition(0))
        {
            return;
        }
        animator.SetTrigger("Pick up");

    }
}
