using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotEsfera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject puntoGiro;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(puntoGiro.transform.position, Vector3.up, 70 * Time.deltaTime);
    }
}
