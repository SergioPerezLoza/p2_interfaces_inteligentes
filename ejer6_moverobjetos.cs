using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjetos : MonoBehaviour
{
    // Variables públicas para asignar los objetos desde el Inspector
    public GameObject objeto1;  // Asignar esfera
    public GameObject objeto2;  // Asignar cubo
    public GameObject objeto3;  // Asignar cilindro

    // Variables para los desplazamientos (Vector3) para cada objeto
    public Vector3 desplazamiento1;
    public Vector3 desplazamiento2;
    public Vector3 desplazamiento3;

    // Posiciones originales de los objetos (guardadas al inicio)
    private Vector3 posicionOriginal1;
    private Vector3 posicionOriginal2;
    private Vector3 posicionOriginal3;

    void Start()
    {
        // Guardar las posiciones originales de los objetos al inicio
        posicionOriginal1 = objeto1.transform.position;
        posicionOriginal2 = objeto2.transform.position;
        posicionOriginal3 = objeto3.transform.position;
    }

    void Update()
    {
        // Detectar si se ha pulsado la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Mover los objetos a las nuevas posiciones calculadas
            objeto1.transform.position = posicionOriginal1 + desplazamiento1;
            objeto2.transform.position = posicionOriginal2 + desplazamiento2;
            objeto3.transform.position = posicionOriginal3 + desplazamiento3;
        }
    }
}
