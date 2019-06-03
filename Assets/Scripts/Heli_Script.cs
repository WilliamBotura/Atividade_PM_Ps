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
        //float aleatorio = UnityEngine.Random.Range(-180, 180);
        //if (aleatorio == -180 || aleatorio == -90 || aleatorio == 90 || aleatorio == 180)
        //{
        //    Vector3 rotacao = new Vector3(0, aleatorio, 0);
        //    Quaternion rotation = Quaternion.Euler(rotacao);
        //}
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
