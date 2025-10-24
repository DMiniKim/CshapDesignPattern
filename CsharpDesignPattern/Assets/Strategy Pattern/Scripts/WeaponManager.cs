using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    [SerializeField] List<Weapon> weaponList;
    Vector3 bulletPoint;
    int currentWeapon = 0;
    

    private void Start()
    {
        weaponList[currentWeapon].gameObject.SetActive(true);        
    }
    private void Update()
    {
        Shot();
        ChangeShotGun();
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
        if (Input.GetKeyDown(KeyCode.Space))            
        {
            weaponList[currentWeapon].gameObject.SetActive(false);
            currentWeapon++; 
            currentWeapon = currentWeapon % weaponList.Count;
            weaponList[currentWeapon].gameObject.SetActive(true);
        }

    }

}
