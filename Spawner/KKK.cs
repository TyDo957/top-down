using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KKK : MonoBehaviour
{
    [SerializeField] private float spawnerRadis = 7f, time = 1.5f;
    public GameObject[] enemies;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnerEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spawnerEnemy()
    {
        Vector2 spawnpos = GameObject.Find("Player").transform.position;
        spawnpos += Random.insideUnitCircle.normalized * spawnerRadis;

        Instantiate(enemies[Random.Range(0, enemies.Length)], spawnpos, Quaternion.identity);
        yield return new WaitForSeconds(time);
        StartCoroutine(spawnerEnemy());
    }
}
