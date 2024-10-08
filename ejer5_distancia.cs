using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanciaEsfera : MonoBehaviour
{
    // Referencias a los objetos cubo y cilindro
    private GameObject cubo;
    private GameObject cilindro;

    // Start es llamado al principio de la ejecución de la escena
    void Start()
    {
        // Buscar el cubo y el cilindro por su etiqueta
        cubo = GameObject.FindWithTag("Cube");
        cilindro = GameObject.FindWithTag("Cylinder");

        // Si encontramos ambos objetos, calculamos las distancias
        if (cubo != null && cilindro != null)
        {
            // Calcular la distancia entre la esfera (este objeto) y el cubo
            float distanciaCubo = Vector3.Distance(transform.position, cubo.transform.position);
            Debug.Log("Distancia a cubo: " + distanciaCubo);

            // Calcular la distancia entre la esfera y el cilindro
            float distanciaCilindro = Vector3.Distance(transform.position, cilindro.transform.position);
            Debug.Log("Distancia a cilindro: " + distanciaCilindro);
        }
        else
        {
            Debug.Log("No se encontraron los objetos cubo o cilindro.");
        }
    }
}
