using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject barrel;
    public GameObject rock;
    public GameObject stump;
    public GameObject eagle;
    public GameObject onion;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;

    // Update is called once per frame
    void Update()
    {
        if(Time.time>spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        int scelta = Random.Range(0,5);

        if(scelta==0){
            Instantiate(barrel, transform.position + new Vector3(randomX, randomY, -1f), transform.rotation);
        }
        else if(scelta==1){
            Instantiate(rock, transform.position + new Vector3(randomX, randomY, -1f), transform.rotation);
        }
        else if(scelta==2){
            Instantiate(stump, transform.position + new Vector3(randomX, randomY, -1f), transform.rotation);
        }
        else if(scelta==3){
            int prob = Random.Range(0,7);
        
            if(prob==0){
                int eagleY = Random.Range(-2,4);
                Instantiate(eagle, transform.position + new Vector3(randomX, eagleY, -1f), transform.rotation);
            }
        }
        else if(scelta==4){
            int onionProb = Random.Range(0,3);
            if(onionProb==0){
                Instantiate(onion, transform.position + new Vector3(randomX, randomY, -1f), transform.rotation);
            }
        }
    }
}
