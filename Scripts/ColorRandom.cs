using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandom : MonoBehaviour
{

    //esto es el primer commit en local

    //este es el segundo commit
    public SpriteRenderer sr;

    void Start()
    {
        InvokeRepeating("Colores",5.0f, 5.0f);
    }

    void Colores()
    {
        sr.color = Random.ColorHSV();
    }
}
