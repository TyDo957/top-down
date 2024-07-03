using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DitectionZone : MonoBehaviour
{
    public string TagTarget = "Player";
    public List<Collider2D> dectecobject = new List<Collider2D>();

    private void OnTriggerEnter2D(Collider2D colider)
    {
        if(colider.gameObject.tag == TagTarget)
        {
            dectecobject.Add(colider);
        }
    }
    private void OnTriggerExit2D(Collider2D colider)
    {
        if(colider.gameObject.tag == TagTarget )
        {
            dectecobject.Remove(colider);
        }
    }
}
