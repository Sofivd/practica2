using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverJuego : MonoBehaviour
{
    public void Volver()
    {
        SceneManager.LoadScene("menuprincipal");
    }
}
