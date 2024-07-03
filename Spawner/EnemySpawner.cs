using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawRate = 1f;
    [SerializeField] private GameObject [] enemyprefab;
    [SerializeField] private bool canSpawner = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new  WaitForSeconds(spawRate);

        while (canSpawner)
        {
            yield return wait;
            int rand = Random.Range(0, enemyprefab.Length);
            GameObject enemyTospawn = enemyprefab[rand];


            Instantiate(enemyTospawn , transform.position , Quaternion.identity);
        }
    }
}
