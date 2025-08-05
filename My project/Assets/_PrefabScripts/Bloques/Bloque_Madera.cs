using UnityEngine;

public class Bloque_Madera : Bloque
{
    void Start()
    {
        resistencia = 3;
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
