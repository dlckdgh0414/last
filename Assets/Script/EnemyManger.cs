using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManger : MonoBehaviour
{
    private float currentime=0f;
    private float creattime = 1f;
    public GameObject EnemyPrefab;
    private float maxTime = 4f;
    private float minTime = 1f;
    void Start()
    {
        creattime = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        currentime += Time.deltaTime;
        if(currentime>creattime)
        {
            Instantiate(EnemyPrefab, transform);
            creattime = Random.Range(minTime, maxTime);
            currentime = 0f;
        }
    }
}
