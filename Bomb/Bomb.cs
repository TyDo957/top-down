using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
   
    public float fieldofImpact;
    public float force;
    public LayerMask layertohit;
    bool isShot = false;  // Flag to indicate explosion trigger
    public GameObject Tet;
    public GameObject explosionEffect;
    // Update is called once per frame
    void Update()
    {
      
    }
  
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position,fieldofImpact);
    }

  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(Tet, transform.position, Quaternion.identity);
        Destroy(collision.gameObject);
        Destroy(gameObject);
        
        // Explosion logic remains unchanged
        Collider2D[] objcet = Physics2D.OverlapCircleAll(transform.position, fieldofImpact, layertohit);
        foreach (Collider2D obj in objcet)
        {
            Vector2 direction = obj.transform.position - transform.position;
            obj.GetComponent<Rigidbody2D>().AddForce(direction * force);
        }
        GameObject ExplosionEffectIn = Instantiate(explosionEffect, transform.position, Quaternion.identity);
        Destroy(ExplosionEffectIn, 10);
        Destroy(gameObject);
        
    }
}
