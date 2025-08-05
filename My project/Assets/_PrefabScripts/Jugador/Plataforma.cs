using UnityEngine;

public class Plataforma: MonoBehaviour
{
    [SerializeField] public float limiteX = 7.5f;
    [SerializeField] public float velocidad = 0.5f;
    Transform transform;   
    Vector3 PlayerPos2D;
    
    
   
    void Start()
    {
        transform = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }

        Vector3 pos = transform.position;


        if (pos.x < limiteX)
        {
            pos.x = -limiteX;
        }
        else if (pos.x > limiteX)
        {
            pos.x = limiteX;
        }

          transform.position = pos;
          Debug.Log(pos.x);
    }

 
}
