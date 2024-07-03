using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunshells : MonoBehaviour
{
    public Transform shellExtractor;
    public Rigidbody2D sheell;
    private float randomExtraction , ramtoque;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.Fire();
    }
    public void Fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            randomExtraction = Random.Range(10f, 20f);
            ramtoque = Random.Range(100f, 200f);
            this.ExtracShell();
        }
       
    }
    public void ExtracShell()
    {
        var extractedshell = Instantiate(sheell, shellExtractor.position, shellExtractor.rotation);
        extractedshell.AddForce(shellExtractor.up * randomExtraction, ForceMode2D.Force);
        extractedshell.AddTorque(ramtoque);
    }
}
