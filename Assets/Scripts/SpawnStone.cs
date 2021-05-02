using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStone : MonoBehaviour
{
    public GameObject stoneToSpawn;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            Instantiate(stoneToSpawn, getRandomPos(), Quaternion.identity);
        }
    }

    Vector3 getRandomPos()//генерация случайной координаты для спауна камней 
    {
        float _x = Random.Range(minX, maxX);
        float _y = 0.5f;
        float _z = Random.Range(minZ, maxZ);

        Vector3 newPos = new Vector3(_x, _y, _z);

        return newPos;
    }

}
