using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPosition : MonoBehaviour
{
    // Start es llamado al principio de la ejecución de la escena
    void Start()
    {
        // Obtener la posición del objeto (esfera) y mostrarla en la consola
        Vector3 spherePosition = transform.position;
        Debug.Log("Posición inicial de la esfera: " + spherePosition);
    }
}
