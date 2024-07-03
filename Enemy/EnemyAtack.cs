using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAtack : MonoBehaviour
{
   // public float speed = 3f;
    public Transform target;
    [SerializeField] private float attackDame = 10f;
    [SerializeField] private float atackSpeed = 1f;
    private float canAtack;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            target = other.transform;
        }
    }
    private void OnCollisionStay2D(Collision2D other)           
    {
        if (other.gameObject.tag == "Player")
        {
            if(atackSpeed <= canAtack)
            {
                other.gameObject.GetComponent<PlayerHealt>().UpdateHealth(-attackDame);
                canAtack = 0f;


            }
            else
            {

               
                canAtack += Time.deltaTime;
            }
           
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            target = null;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
      //  if(target != null)
        {
            //float step = speed * Time.deltaTime;
          //  transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        }
    }
   
}
