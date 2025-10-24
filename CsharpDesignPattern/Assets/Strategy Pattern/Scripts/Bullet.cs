using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    [SerializeField] float bulletSpeed = 1f;
 
    // Update is called once per frame
    private void Start()
    {        
        Destroy(gameObject, 5.0f);
    }
    void Update()
    {        
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
    }

    
}
