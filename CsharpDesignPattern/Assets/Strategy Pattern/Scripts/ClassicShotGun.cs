using UnityEngine;

public class ClassicShotGun : Weapon
{
    [SerializeField] protected GameObject bullet;
    [SerializeField] protected Transform muzzlePosition;

    private void Start()
    {
        muzzlePosition.position = transform.GetChild(0).position;   
    }
    public override void Attack()
    {
        Debug.Log("ClassicShotGun Attack");
        Instantiate(bullet, muzzlePosition.position,transform.rotation);
    }  
        
}
