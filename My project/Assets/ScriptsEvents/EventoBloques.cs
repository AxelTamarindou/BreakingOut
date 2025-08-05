using UnityEngine;
using UnityEngine.Events;

public class EventoBloques : MonoBehaviour
{
    public UnityEvent BloqueStart;
    public Bloque bloque;

    private void Start()
    {
        bloque = GetComponent<Bloque>();
        Debug.Log($"La resistencia actual del bloque es {bloque.resistencia}");
    }
    void Update()
    {
        //if (bloque.resistencia == 0)
        //{
        //    BloqueStart.Invoke();
        //}    
    }
    
    public void BloqueDestruido()
    {
        Debug.Log("Se destruyó el bloque");
    }
}
