using UnityEngine;
using System.Collections;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject robot;
    [SerializeField] WaitForSeconds waitForSeconds;

    private void Awake()
    {
        waitForSeconds = CoroutineManager.WaitForSecond(Random.Range(1f,5f));
        StartCoroutine(CreateRobot());
    }


    public IEnumerator CreateRobot()
    {
        while (true)
        {
            Instantiate(robot);
            robot.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            yield return waitForSeconds;
        }
    }

}
