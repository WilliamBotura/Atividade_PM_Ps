using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Target : MonoBehaviour
{
    public Transform Target;
    public string TargetTag;
    public float velMovimento = 3.0f;
    public bool lookAt = false;

    void Start()
    {
    }

    void Update()
    {
        ProcurarTarget();
        Movimentar();
        Rotacionar();
    }

    private void ProcurarTarget()
    {
        if (TargetTag == "" || Target != null)
        {
            return;
        }

        GameObject[] Targets = GameObject.FindGameObjectsWithTag(TargetTag);
        Transform possivelTarget = null;

        foreach (GameObject checarTarget in Targets)
        {
            if (possivelTarget == null)
            {
                possivelTarget = checarTarget.transform;
            }
        }
        if (possivelTarget != null)
        {
            Target = possivelTarget.transform;
        }
    }

    private void Movimentar()
    {
        if (lookAt || Target == null)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * velMovimento);
        }
        else if (Target != null)
        {
            Vector3 dir = (Target.position - transform.position).normalized;
            transform.Translate(dir * velMovimento * Time.deltaTime, Space.World);
        }
    }

    private void Rotacionar()
    {
        if (lookAt || Target != null)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(Target.position - transform.position), Time.deltaTime * velMovimento);
        }
    }
}
