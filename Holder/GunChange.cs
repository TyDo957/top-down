using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class GunChange : MonoBehaviour
{
    public WeaponHolder weaponNN;

    // Start is called before the first frame update
    void Start()
    {
        weaponNN = GetComponentInChildren<WeaponHolder>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject whathit = collision.gameObject;

        if (whathit.CompareTag("RPG"))
        {
            weaponNN.guns[0].SetActive(false);
            weaponNN.guns[2].SetActive(false);
            weaponNN.guns[1].SetActive(true);
            StartCoroutine(Normal());
        }

        if (whathit.CompareTag("GUNN"))
        {
            weaponNN.guns[0].SetActive(false);
            weaponNN.guns[2].SetActive(true);
            weaponNN.guns[1].SetActive(false);
            StartCoroutine(Normal());
        }
        
        if (whathit.CompareTag("Ramdom"))
        {
            weaponNN.guns[0].SetActive(false);
            weaponNN.guns[2].SetActive(false);
            weaponNN.guns[1].SetActive(false);
            weaponNN.guns[Random.Range(1,3)].SetActive(true);

           // StartCoroutine(Normal());
        }
        
    }
    IEnumerator Normal()
    {
        Debug.Log("normal playing ");
        yield return new WaitForSeconds(100000);
        weaponNN.guns[2].SetActive(false);
        weaponNN.guns[1].SetActive(false);
        weaponNN.guns[0].SetActive(true);
        Debug.Log("ENUEMTR");
    }
}
