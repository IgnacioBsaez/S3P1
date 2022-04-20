using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad;

    public Vector2 direccion;
    public float limiteXizquierda, limiteXderecha, limiteYarriba, limiteYabajo;

    private void Update()
    {
        direccion.x = Input.GetAxisRaw("Horizontal");
        direccion.y = Input.GetAxisRaw("Vertical");

        // normalizar el vector

        transform.Translate(direccion.normalized * velocidad * Time.deltaTime);

        // confinar espacio de movimiento

        Vector2 posicionCorregida = transform.position;

        posicionCorregida.x = Mathf.Clamp(posicionCorregida.x, limiteXizquierda, limiteXderecha);
        posicionCorregida.y = Mathf.Clamp(posicionCorregida.y, limiteYabajo, limiteYarriba);

        transform.position = posicionCorregida;

    }

}
