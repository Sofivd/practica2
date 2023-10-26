using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Oveja;
    public float offsetY;
    public float offsetZ;
    void Start()
    {
        //GameObject.Find;
    }

    // Update is called once per frame
    void Update()
    {
        //(codigo para que la camara siga el objeto)
        //transform.position = Oveja.transform.position; // primero
        transform.position = new Vector3(Oveja.transform.position.x, Oveja.transform.position.y + offsetY, Oveja.transform.position.z - offsetZ);  // tercera
       
        if (Input.GetKeyDown(KeyCode.C))
        {
            offsetZ = 5;

        }
       
    }
    
}
