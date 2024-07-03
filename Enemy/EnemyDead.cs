using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDead : MonoBehaviour
{
 
    public GameObject EnemyDeadd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(EnemyDeadd, transform.position, Quaternion.identity);
        Destroy(collision.gameObject);
      // Destroy(gameObject);


    }
}
