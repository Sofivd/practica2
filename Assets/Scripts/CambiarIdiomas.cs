using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class CambiarIdiomas : MonoBehaviour
{
    public List<Locale> Idiomas;
    public int CambiarIdioma = 2;
    void Start()
    {
        Idiomas = LocalizationSettings.AvailableLocales.Locales;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Español()
    {

        LocalizationSettings.Instance.SetSelectedLocale(Idiomas[2]);
    }

    public void Ingles()
    {
        LocalizationSettings.Instance.SetSelectedLocale(Idiomas[0]);
    }

    public void Japones()
    {
        LocalizationSettings.Instance.SetSelectedLocale(Idiomas[1]);
    }

    public void ProximoIdioma()
    {
        CambiarIdioma++;
        if(CambiarIdioma == 3)
        {
            CambiarIdioma = 0;
        }

        LocalizationSettings.Instance.SetSelectedLocale(Idiomas[CambiarIdioma]);
        

    }

    public void AnteriorIdioma()
    {
        CambiarIdioma--;
        if (CambiarIdioma == -1)
        {
            CambiarIdioma = 2;
        }

        LocalizationSettings.Instance.SetSelectedLocale(Idiomas[CambiarIdioma]);
    }
}
