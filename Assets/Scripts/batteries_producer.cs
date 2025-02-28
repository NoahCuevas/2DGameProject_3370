using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batteries_producer : MonoBehaviour
{
    public GameObject itemPrefab;
    public GameObject particles;
    public float r;

    // MY VARIABLES //
    private score_manager scoreManager;
    public float spawnInterval = 2f;
    public float spawnHeight = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
         for(int i = 0; i < 5; i++)
         {
             spawnObject();
         }
        */

        // MY FUNC //
        scoreManager = FindObjectOfType<score_manager>();
        InvokeRepeating("spawnObject", 0f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.B))
        {
            spawnObject();
        }
        */


        // MY FUNC //
        if (scoreManager.life <= 0)
        {
            CancelInvoke("spawnObject");
        }
    }

    void spawnObject()
    {
        //Vector3 randomPos = Random.insideUnitCircle * r;
        //Instantiate(particles, randomPos, Quaternion.identity);
        //Instantiate(itemPrefab, randomPos, Quaternion.identity);

        // /*
        // My Func //
        if (scoreManager.life <= 0)
        {
            CancelInvoke("spawnObject");
            return;
        }

        Vector3 spawnPos = new Vector3(Random.Range(-r, r), spawnHeight, 0);
        GameObject newBomb = Instantiate(itemPrefab, spawnPos, Quaternion.identity);
        // */
    }
}
