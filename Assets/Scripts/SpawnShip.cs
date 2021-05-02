using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShip : MonoBehaviour
{
    public GameObject[] shipToSpawn;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public int startSpawn;//время начала заплыва корабликов
    public int intervalSpawn;//интервал появления

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNow", startSpawn, intervalSpawn);    
    }

    Vector3 getRandomPos()
    {
        float _x = Random.Range(minX, maxX);
        float _y = 0.5f;
        float _z = Random.Range(minZ, maxZ);

        Vector3 newPos = new Vector3(_x, _y, _z);

        return newPos;
    }
    void SpawnNow()
    {
        Instantiate(shipToSpawn[Random.Range(0,2)], getRandomPos(), Quaternion.identity);
    }

}
