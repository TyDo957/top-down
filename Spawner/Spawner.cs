using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnerPoints;
    GameObject curenpoint;
    int index;

    public GameObject[] enemy;
    public float minTimeSpawner;
    public float maxTimeSpawner;
    public bool canSpawner;
    public float Spawnetime;
    public int enemiesRoom;
    public bool spawnerDone;
    public GameObject spawnerDonegameobject;



    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawneEnemy", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(canSpawner)
        {
            Spawnetime -= Time.deltaTime;
            if(Spawnetime < 0)
            {
                canSpawner = false;
            }
        }
    }
    public void SpawneEnemy()
    {
        index = Random.Range(0, spawnerPoints.Length);
        curenpoint = spawnerPoints[index];
        float timebtSpawner = Random.Range(minTimeSpawner, maxTimeSpawner);

        if (canSpawner)
        {
            Instantiate(enemy[Random.Range(0, enemy.Length)] , curenpoint.transform.position , Quaternion.identity);
            enemiesRoom++;

        }
          Invoke("SpawneEnemy", timebtSpawner);

        if(spawnerDone)
        {
            spawnerDonegameobject.SetActive(true);

        }

    }
}
