using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;

public class Character : MonoBehaviour
{   
    [SerializeField] public Animator animator;

    State state;

    private void Awake()
    {
        animator = GetComponent<Animator>();        
    }
    private void Start()
    {
        state = new Idle();
    }
    private void Update()
    {             
        state.Execute(this);
    }    
    
    public void SetState(State s)
    {
        state.Exit(this);

        this.state = s;

        state.Enter(this);
    }
}
