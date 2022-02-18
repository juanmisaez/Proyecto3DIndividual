using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingLog : MonoBehaviour
{
    /*
    Un script para TODOS los movimientos del juego, todos los elementos que lo necesiten lo tienen y el controller hará uso de las funciones necesarias
    */
    private Rigidbody _rb;

    public float speed;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _rb.transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}