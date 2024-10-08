using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // Variables públicas para el cilindro y el cubo
    public GameObject cilindro;
    public GameObject cubo;

    // Colores para cambiar al presionar las teclas
    public Color colorCilindro = new Color(1.0f, 0.0f, 0.0f);  // Rojo
    public Color colorCubo = new Color(0.0f, 1.0f, 0.0f);      // Verde

    // Update se ejecuta una vez por frame
    void Update()
    {
        // Si el usuario pulsa la tecla C, cambia el color del cilindro
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Acceder al Renderer del cilindro y cambiar su color
            cilindro.GetComponent<Renderer>().material.color = colorCilindro;
        }

        // Si el usuario pulsa la flecha hacia arriba, cambia el color del cubo
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Acceder al Renderer del cubo y cambiar su color
            cubo.GetComponent<Renderer>().material.color = colorCubo;
        }
    }
}
