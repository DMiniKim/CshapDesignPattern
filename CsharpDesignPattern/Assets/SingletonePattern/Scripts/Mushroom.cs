using UnityEngine;

public class Mushroom : MonoBehaviour
{
    [SerializeField] float speed = 50f;
 
    void Update()
    {
        
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
