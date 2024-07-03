using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class EnemyHp : MonoBehaviour
{
    private float health = 3f;
    [SerializeField] private float maxHealth = 3f;



    public GameObject popUpdamageprefab;
   // public TMP_Text popUptext;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Weapon")
        {
            TakeDamege(other.GetComponent<Proticle>().damage);
        }
    }
    public void TakeDamege(float damageamoput)
    {
       // showDamage(damageamoput.ToString());
        health -= damageamoput;
        Instantiate(popUpdamageprefab, transform.position, Quaternion.identity);

        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }


    public void showDamage(string text)
    {
        if(popUpdamageprefab)
        {
            GameObject prefab = Instantiate(popUpdamageprefab, transform.position , Quaternion.identity);
            prefab.GetComponent<TextMeshPro>().text = text;        
        }
       
    }
   
}
