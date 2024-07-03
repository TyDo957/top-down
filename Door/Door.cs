using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door: DitectionZone
{
    public string doorOpen = "DoorOpen";   
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(dectecobject.Count > 0)
        {
            animator.SetBool(doorOpen, true);
        }
       // else
        {
           // animator.SetBool(doorOpen , false);
        }
    }
}
