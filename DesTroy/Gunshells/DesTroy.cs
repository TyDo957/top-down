using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesTroy : MonoBehaviour
{
    [SerializeField] private float SeconDesTroy = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, SeconDesTroy);
    }
}
