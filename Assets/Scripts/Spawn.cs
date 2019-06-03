using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Helicoptero;
    public Transform SpawnTransform;
    public float velocidadeSpawn = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFunc());
    }

    // Update is called once per frame
    void Update()
    {
        //SpawnFunc();
    }

    IEnumerator SpawnFunc()
    {
        float[] rotacao = new float[] {0, -180, -90, 90, 180 };
        Instantiate(Helicoptero, SpawnTransform.position, Quaternion.Euler(0f ,rotacao[UnityEngine.Random.Range(0, rotacao.Length)], 0f));
        yield return new WaitForSeconds(velocidadeSpawn);
        StartCoroutine(SpawnFunc());
    }
}
