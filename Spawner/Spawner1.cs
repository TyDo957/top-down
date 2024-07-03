using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    [SerializeField] private GameObject swrnePrefab;
    [SerializeField] private float time = 3f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawner(time, swrnePrefab));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator spawner (float interl , GameObject enemy)
    {
        yield return new WaitForSeconds(time);
        GameObject newEnemy = Instantiate(enemy , new Vector3(Random.Range(-5f , 5) , Random.Range(-6 , 6F) , 0) , Quaternion.identity);
        StartCoroutine(spawner(interl , enemy));
    }
}
