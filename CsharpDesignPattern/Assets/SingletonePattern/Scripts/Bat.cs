using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class Bat : MonoBehaviour
{
    [SerializeField] float targetY;
    
    //Vector3 upPosition;
    //Vector3 downPosition;

    void Start()
    {
        //upPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1f, gameObject.transform.position.z);
        //downPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1f, gameObject.transform.position.z);
        //Mathf.PingPong(gameObject.transform.position.y, upPosition.y);
    }


    void Update()
    {
        if (GameManager.Instance.State == false)
        {
            float y = Mathf.PingPong(Time.time, targetY) - 1;

            transform.position = new Vector3(transform.position.x, y, transform.position.z);
        }
    }
}
