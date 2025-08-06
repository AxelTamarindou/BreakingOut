using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Events;

public class Bloque : MonoBehaviour
{
    public int resistencia = 2;
    public AdministradordeMenús Niveles;
    public UnityEvent AumentarPuntaje;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bola")
        {
            RebotarBola(collision);
        }

    }
    public virtual void RebotarBola(Collision collision)
    {
        Vector2 direccion = collision.contacts[0].point - transform.position;
        direccion = direccion.normalized;
        collision.rigidbody.linearVelocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;
        resistencia--;
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia <= 0)
        {
            
            Destroy(this.gameObject);
        }
    }

}
