using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomcolor : MonoBehaviour
{
    // Parámetro público para cambiar el número de frames desde el Inspector
    public int framesInterval = 120;

    // Contador de frames
    private int framesCounter = 0;

    // Vector para representar el color
    private Color currentColor;  // Cambié el nombre de randomcolor a currentColor

    // Componente Renderer para cambiar el material del objeto
    private Renderer objectRenderer;

    // Start es llamado antes del primer frame update
    void Start()
    {
        // Inicializar un color aleatorio
        currentColor = new Color(Random.value, Random.value, Random.value);

        // Obtener el componente Renderer del objeto
        objectRenderer = GetComponent<Renderer>();

        // Asignar el color inicial
        objectRenderer.material.color = currentColor;
    }

    // Update es llamado una vez por frame
    void Update()
    {
        // Incrementar el contador de frames
        framesCounter++;

        // Verificar si han pasado los frames especificados
        if (framesCounter >= framesInterval)
        {
            // Cambiar el valor de una de las posiciones (R, G o B) de manera aleatoria
            int colorComponent = Random.Range(0, 3);  // Elegir un componente al azar

            if (colorComponent == 0)
            {
                currentColor.r = Random.value;
            }
            else if (colorComponent == 1)
            {
                currentColor.g = Random.value;
            }
            else if (colorComponent == 2)
            {
                currentColor.b = Random.value;
            }

            // Asignar el nuevo color al objeto
            objectRenderer.material.color = currentColor;

            // Reiniciar el contador de frames
            framesCounter = 0;
        }
    }
}
