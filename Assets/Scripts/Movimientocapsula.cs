using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientocapsula : MonoBehaviour
{
    // Start is called before the first frame update
    public float movX, movZ;
    Rigidbody fisicas;
    float speed = 8f;
    public bool sobreSuelo = false;
    public bool saltar = false;
    public float fuerzadeSalto = 10f;
    public bool gameOver;
    void Start()
    {
        fisicas = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");
        // Vector3 direccion = new Vector3(movX, movZ);
        // transform.Translate(direccion * Time.deltaTime * 10);


        if (Input.GetButtonDown("Jump"))
        {
          saltar = true;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        sobreSuelo = true;


        if (collision.gameObject.tag == "Suelo")
        {
            sobreSuelo = true;

        }
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            Debug.Log("Game Over");
            gameOver = true;
            Time.timeScale = 0f;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Recolectable")
        {
            Destroy(other.gameObject);
        }
    }

    private void FixedUpdate()
    {
        Vector3 nuevaVelocidad = new Vector3(movX * speed, fisicas.velocity.y, movZ * speed);
        fisicas.velocity = nuevaVelocidad;

        if (saltar && sobreSuelo)
        {
            fisicas.AddForce(Vector3.up * fuerzadeSalto, ForceMode.Impulse);
            saltar = false;
            sobreSuelo = false;
        }
    }

}
