using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb2 : MonoBehaviour
{
    public float radio;
    public float fuzeploss;
    public GameObject explosionEffect;
    private void Update()
    {
      //  if (Input.GetMouseButton(0))
        {
          //  this.explosion();
        }
      
    }
   /// <summary>
    public GameObject Tet;
   /// </summary>
   /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(Tet, transform.position, Quaternion.identity);
       // Destroy(collision.gameObject);
      //  Destroy(gameObject);
        Collider2D[] objectt = Physics2D.OverlapCircleAll(transform.position, radio);
        foreach (Collider2D bjo in objectt)
        {
            Rigidbody2D rb2d = bjo.GetComponent<Rigidbody2D>();
            if (rb2d != null)
            {
                Vector2 direction = rb2d.transform.position - transform.position;
                float distancia = 1 + direction.magnitude;
                float fuerFinal = fuzeploss / distancia;
                rb2d.AddForce(direction * fuerFinal);
            }
           GameObject ExplosionEffectIn = Instantiate(explosionEffect, transform.position, Quaternion.identity);
            Destroy(ExplosionEffectIn, 1);

        }
    }
    public void explosion()
    {
        Collider2D[] objectt = Physics2D.OverlapCircleAll(transform.position, radio);
        foreach (Collider2D bjo in objectt)
        {
           Rigidbody2D rb2d = bjo.GetComponent<Rigidbody2D>();
            if(rb2d != null)
            {
                Vector2 direction = rb2d.transform.position - transform.position;
                float distancia = 1 + direction.magnitude;
                float fuerFinal = fuzeploss / distancia;
                rb2d.AddForce(direction *  fuerFinal);
            }
           GameObject ExplosionEffectIn = Instantiate(explosionEffect, transform.position, Quaternion.identity);
            Destroy(ExplosionEffectIn, 10);
        }
      
       // Destroy(gameObject);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radio);
    }

}
