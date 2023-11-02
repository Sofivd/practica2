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
    public GameObject menuPausa;
    bool estaEnPausa;


    void Start()
    {
        fisicas = GetComponent<Rigidbody>();
        estaEnPausa = false;
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");
        // Vector3 dir eccion = new Vector3(movX, movZ);
        // transform.Translate(direccion * Time.deltaTime * 10);


        if (Input.GetButtonDown("Jump"))
        {
          saltar = true;

        }

        if(Input.GetKeyDown(KeyCode.Escape) == true)
        {
            if(estaEnPausa == true)
            {
                menuPausa.gameObject.SetActive(false);
                estaEnPausa = false;
                Time.timeScale = 1.0f;
            }
            else
            {
                menuPausa.gameObject.SetActive(true);
                estaEnPausa = true;
                Time.timeScale = 0.0f;
            }
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
