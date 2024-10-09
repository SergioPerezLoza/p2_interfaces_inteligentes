using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorOperations : MonoBehaviour
{
    // Variables públicas para asignar los vectores desde el Inspector
    public Vector3 vectorA;
    public Vector3 vectorB;

    // Variables para mostrar en el Inspector los resultados
    public float magnitudA;
    public float magnitudB;
    public float anguloEntreVectores;
    public float distanciaEntreVectores;
    public string vectorMayorAltura;

    void Start()
    {
        // Calcular la magnitud de cada vector
        magnitudA = vectorA.magnitude;
        magnitudB = vectorB.magnitude;

        // Calcular el ángulo entre los vectores en grados
        anguloEntreVectores = Vector3.Angle(vectorA, vectorB);

        // Calcular la distancia entre los vectores
        distanciaEntreVectores = Vector3.Distance(vectorA, vectorB);

        // Determinar cuál vector tiene mayor altura (componente Y)
        if (vectorA.y > vectorB.y)
        {
            vectorMayorAltura = "Vector A tiene mayor altura.";
        }
        else if (vectorA.y < vectorB.y)
        {
            vectorMayorAltura = "Vector B tiene mayor altura.";
        }
        else
        {
            vectorMayorAltura = "Ambos vectores están a la misma altura.";
        }

        // Mostrar los resultados en la consola
        Debug.Log("Magnitud del Vector A: " + magnitudA);
        Debug.Log("Magnitud del Vector B: " + magnitudB);
        Debug.Log("Ángulo entre los vectores: " + anguloEntreVectores + " grados");
        Debug.Log("Distancia entre los vectores: " + distanciaEntreVectores);
        Debug.Log(vectorMayorAltura);
    }
}

