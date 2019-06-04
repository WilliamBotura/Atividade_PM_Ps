using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heli_Script : MonoBehaviour
{
    public float velocidadeTranslate = 3.0f;


    void Start()
    {

    }

    void Update()
    {
        Movimentar();
    }

    private void Movimentar()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
