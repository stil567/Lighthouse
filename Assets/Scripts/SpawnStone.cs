using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStone : MonoBehaviour
{
    public GameObject stoneToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            Instantiate(stoneToSpawn, getRandomPos(), Quaternion.identity);
        }
    }

    Vector3 getRandomPos()
    {
        float _x = Random.Range(-20, 20);
        float _y = 0.5f;
        float _z = Random.Range(-40, 50);

        Vector3 newPos = new Vector3(_x, _y, _z);

        return newPos;
    }

}
