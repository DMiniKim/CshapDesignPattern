using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Robot : MonoBehaviour
{
    float currentTime = 0;
    float waitTime = 1.5f;
    float moveSpeed = 4f;
    float travelDistance = 10f;
    Animator animator;
    bool isRunning = false;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > waitTime)
        {
            isRunning = true;
            animator.SetTrigger("Run");
        }
        if (isRunning)
        {
            transform.position += transform.forward * Time.deltaTime * moveSpeed;
        }
        if (currentTime > travelDistance)
        {
            transform.Rotate(0, 180, 0);
            currentTime = 0;
        }

    }
}
