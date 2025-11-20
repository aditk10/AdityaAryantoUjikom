using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject spawnEnemy;
    public bool sedangSpawn = true;

    public float intervalSpawn = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(MunculkanEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MunculkanEnemy()
    {
        while (sedangSpawn == true)
        {
            Instantiate(spawnEnemy, new Vector3(Random.Range(-5,5), 5 ,0), Quaternion.identity);
            yield return new WaitForSeconds(intervalSpawn);
        }
    }
}
