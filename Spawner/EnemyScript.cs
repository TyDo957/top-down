using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Spawner spawner;

    public void TakeDamage()
    {
        Destroy(gameObject);
        spawner = FindObjectOfType<Spawner>();
        spawner.enemiesRoom--;

        if (spawner.Spawnetime <= 0 && spawner.enemiesRoom <= 0)
        {
            spawner.spawnerDone = true;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
