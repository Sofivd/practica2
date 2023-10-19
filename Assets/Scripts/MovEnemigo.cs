using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEnemigo : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.0f;
    private Transform target;
    void Start()
    {
        transform.position = new Vector3(97f, 1.8f, 52f);

        var Capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        Capsule.transform.localScale = new Vector3(96.46f, 2.42f, 51.72f);
        target = Capsule.transform;
        


       // Camera.main.transform.position = new Vector3(0.85f, 1.0f, -3.0f);
       // Camera.main.transform.localEulerAngles = new Vector3(15.0f, -20.0f, -0.5f);

        GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Plane);
        floor.transform.position = new Vector3(95.27f, 1.42f, 51.33f);
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            {

                target.position *= -1.0f;

            }

        }
    }
}
