using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipProgress : MonoBehaviour
{
    public float MoveSpeed = 10f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 0), Time.deltaTime * MoveSpeed);//�������� ��������� � ������
        
    }
}
