using System;
using UnityEngine;

public class Plataforma: MonoBehaviour
{
    [SerializeField] public float limiteX = 7.5f;
    [SerializeField] public float velocidad = 25f;
    new Transform transform;

    void Start()
    {
        transform = this.gameObject.transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bola")
        {
            Debug.Log("La collision de la pelota jaló");
            Vector2 direccion = collision.contacts[0].point - transform.position;
            direccion = direccion.normalized;
            collision.rigidbody.linearVelocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * velocidad * Time.deltaTime);
            Debug.Log("Movimiento hacia la izquierda");
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * velocidad * Time.deltaTime);
            Debug.Log("Movimiento hacia la derecha");
        }

        Vector2 pos = transform.position;


        if (pos.x < -limiteX)
        {
            pos.x = -limiteX;
        }
        else if (pos.x > limiteX)
        {
            pos.x = limiteX;
        }

        transform.position = pos;

    }
   

}
