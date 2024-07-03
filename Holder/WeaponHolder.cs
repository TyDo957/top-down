using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour
{
    int weapontotal = 1;
    public static int currenWeponIndex;

    public GameObject[] guns;
    public GameObject weaponHolder;
    public GameObject currenGun;

    // Start is called before the first frame update
    void Start()
    {
        weapontotal = weaponHolder.transform.childCount;
        guns = new GameObject[weapontotal];

        for(int i = 0; i < weapontotal; i++)
        {
            guns[i] = weaponHolder.transform.GetChild(i).gameObject;
            guns[i].SetActive(false);

            guns[0].SetActive(true);
            currenGun = guns[0];
            currenWeponIndex = 0;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
