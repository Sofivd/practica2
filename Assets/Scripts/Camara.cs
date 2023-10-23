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
        transform.position = Oveja.transform.position;
        // transform.position = new Vector3(Oveja.transform.position.x, transform.position.y + offsetY, transform.position.z + offsetZ);
    }
    
}
