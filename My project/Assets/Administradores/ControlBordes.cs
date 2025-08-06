using UnityEngine;

public class ControlBordes : MonoBehaviour
{
    [Header("Configurar en el editor")]
    public float radio = 1f;
    public bool mantenerEnPantalla = false;

    [Header("Configuraciiones dinámicas")]
    public bool estaEnPantalla = true;
    public float anchoCamara;
    public float altoCamara;
    public bool salioDerecha, salioIzquierda, salioArriba, salioAbajo;
    public void Awake()
    {
        altoCamara = Camera.main.orthographicSize;
        anchoCamara = Camera.main.aspect * altoCamara;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector2 pos = transform.position;
        estaEnPantalla = true;
        salioAbajo = salioArriba = salioDerecha = salioIzquierda = false;

        if (pos.x > anchoCamara - radio)
        {
            pos.x = anchoCamara - radio;
            salioDerecha = true;
        }

        if (pos.x < anchoCamara - radio)
        {
            pos.x = -anchoCamara + radio;
            salioIzquierda = true;
        }

        if (pos.y > altoCamara - radio)
        {
            pos.y = altoCamara - radio;
            salioArriba = true;
        }

        if (pos.y < -altoCamara + radio)
        {
            pos.y = -altoCamara + radio;
            salioAbajo = true;
        }
        
        estaEnPantalla = !(salioAbajo || salioArriba || salioDerecha || salioIzquierda);
        if (mantenerEnPantalla && !estaEnPantalla)
        {
            transform.position = pos;
            estaEnPantalla = true;
        }
    }

    private void OnDrawGizmos()
    {
        if (!Application.isPlaying) return;
        Vector2 tamañoBorde = new Vector2(anchoCamara * 2, altoCamara * 2);
        Gizmos.DrawWireCube(Vector3.zero, tamañoBorde);
    }
}
