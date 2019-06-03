using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_Spawn : MonoBehaviour
{
    public GameObject projetil;
    public Transform SpawnPoint;


    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(projetil, SpawnPoint.position, SpawnPoint.transform.rotation);
        }
    }
}
