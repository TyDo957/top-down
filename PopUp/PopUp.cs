using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public float DesTrucTime;
    private float Timer;
    // Start is called before the first frame update
    void Start()
    {
        DesTrucTime = Timer;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if(Timer < 0)
        {
            Destroy(gameObject);
        }
    }
}
