using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botoninicio : MonoBehaviour
{

    private float duracion = 1.0f;
    private LeanTweenType tipoDeEasing = LeanTweenType.easeOutQuad;
    public void Iniciar()
    {
        SceneManager.LoadScene("practica2");
    }

    private void AnimarPosicion()
    {
        LeanTween.move(gameObject, new Vector3(2f, 1f, 0f), 10).setEase(LeanTweenType.easeInSine);
    }
}
