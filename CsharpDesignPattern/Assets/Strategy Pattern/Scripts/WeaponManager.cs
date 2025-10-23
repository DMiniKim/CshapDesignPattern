using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    [SerializeField] List<Weapon> weaponList;
    int currentWeapon = 0;

    private void Start()
    {
                
    }
    private void Update()
    {
        Shot();       
    }

    void Shot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            weaponList[currentWeapon].Attack();
        }
    }
    void ChangeShotGun()
    {
        if (!Input.GetKeyDown(KeyCode.Space))            
        {
            currentWeapon++; 
            currentWeapon %= weaponList.Count;
        }

    }

}
