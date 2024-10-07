using UnityEngine;

public class ShowName : MonoBehaviour
{
    void Start()
    {
        // Mostrar el nombre del objeto en la consola
        Debug.Log("I am a " + gameObject.name);
    }
}
