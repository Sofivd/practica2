using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        Debug.Log("Menú cerrado");
    }

    public void Dificultadopcion(bool nuevoEstado)
    {
        Debug.Log("La dificultad está en " + nuevoEstado);
    }
}
