using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    // Variable para el cubo
    public GameObject cubo;

    // Distancia de incremento en la altura
    public float alturaIncremento = 0.05f;

    // Variables para controlar si la altura y el color ya fueron modificados
    private bool alturaIncrementada = false;
    private bool colorCambiado = false;

    // Update se ejecuta una vez por frame
    void Update()
    {
        // Obtener todas las esferas con la etiqueta tipo2
        GameObject[] esferasTipo2 = GameObject.FindGameObjectsWithTag("tipo2");

        if (esferasTipo2.Length > 0)
        {
            // Inicializar variables para la esfera más cercana y más lejana
            GameObject esferaMasCercana = null;
            GameObject esferaMasLejana = null;
            float distanciaMasCercana = float.MaxValue;
            float distanciaMasLejana = float.MinValue;

            // Calcular distancias
            foreach (GameObject esfera in esferasTipo2)
            {
                float distancia = Vector3.Distance(cubo.transform.position, esfera.transform.position);

                // Encontrar la esfera más cercana
                if (distancia < distanciaMasCercana)
                {
                    distanciaMasCercana = distancia;
                    esferaMasCercana = esfera;
                }

                // Encontrar la esfera más lejana
                if (distancia > distanciaMasLejana)
                {
                    distanciaMasLejana = distancia;
                    esferaMasLejana = esfera;
                }
            }

            // Aumentar la altura de la esfera más cercana solo una vez
            if (esferaMasCercana != null && !alturaIncrementada)
            {
                esferaMasCercana.transform.position += new Vector3(0, alturaIncremento, 0); // Aumentar la altura
                alturaIncrementada = true; // Marcar que ya se ha incrementado la altura
            }

            // Cambiar el color de la esfera más lejana al pulsar la barra espaciadora, solo una vez
            if (Input.GetKeyDown(KeyCode.Space) && esferaMasLejana != null && !colorCambiado)
            {
                esferaMasLejana.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
                colorCambiado = true; // Marcar que ya se ha cambiado el color
            }
        }
    }
}
