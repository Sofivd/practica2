using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonIdiomas : MonoBehaviour
{
    public void Idiomas()
    {
        SceneManager.LoadScene("CambiarIdioma");
    }

}
