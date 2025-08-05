using UnityEngine;

public class Plataforma: MonoBehaviour
{
    [SerializeField] public float limiteX = 7.5f;
    [SerializeField] public float velocidad = 10f;
    new Transform transform;   
    
    
    
   
    void Start()
    {
        transform = this.gameObject.transform;
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
