using UnityEngine;

public class Bloque_Cristal : Bloque
{
    void Start()
    {
        resistencia = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }
}
