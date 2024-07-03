using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llll : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float minnimumSpawner;
    [SerializeField] private float maxnimumSpawner;

    private float timeUnispawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeUnispawner -= Time.deltaTime;
        if(timeUnispawner <= 0)
        {
            Instantiate(enemyPrefab , transform.position , Quaternion.identity);
            settimeunispawner();
        }
    }
    private void settimeunispawner()
    {
        timeUnispawner = Random.Range(minnimumSpawner, maxnimumSpawner);
    }
}
