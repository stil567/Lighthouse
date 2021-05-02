using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShip : MonoBehaviour
{
    public GameObject[] shipToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNow",8,2);    
    }
    
    Vector3 getRandomPos()
    {
        float _x = Random.Range(-35, 35);
        float _y = 0.5f; 
        float _z = Random.Range(-60, 60);

        Vector3 newPos = new Vector3(_x, _y, _z);

        return newPos;
    }
    void SpawnNow()
    {
        Instantiate(shipToSpawn[Random.Range(0,2)], getRandomPos(), Quaternion.identity);
    }

}
