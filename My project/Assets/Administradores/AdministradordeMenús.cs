using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdministradordeMenús : MonoBehaviour
{
    public GameObject IniciarJuego;
    public GameObject Opciones;
    public GameObject SalirdelJuego;
    public GameObject MenúPrincipal;
    public GameObject Ajustes;
    public GameObject Regresar;
    public GameObject MenúPausa;
    public GameObject Layout;
    public GameObject ReanudarPartida;
    public int Nivel;
   
    public void Start()
    {
        //Debug.Log(IniciarJuego);
        //Debug.Log(Opciones);
        //Debug.Log(SalirdelJuego);
        //Debug.Log(MenúPrincipal);
        //Debug.Log(Ajustes);
        //Debug.Log(Regresar);
    }

    public void InicializarElJuego()
    {
        if (IniciarJuego)
        {
            Debug.Log("Se presiono el botón para iniciar el Juego");
            SceneManager.LoadScene(Nivel += 1);
            Debug.Log($"El Nivel es {Nivel}");
        }
    }

    public void MenúOpciones()
    {
        if (Opciones)
        {
            Debug.Log("Se presiono el botón para ir al menú de opciones");
            MenúPrincipal.SetActive(false);
            Opciones.SetActive(true);
            Ajustes.SetActive(false);
        }
    }

    public void MenúAjustes()
    {
        if (Ajustes)
        {
            Debug.Log("Se presiono el botón para ir al menú de opciones");
            Opciones.SetActive(false);
            Ajustes.SetActive(true);
        }
    }

    public void RegresarAlMenú()
    {
        if (Regresar)
        {
            Debug.Log("Se presiono el botón para regresar al Menú Principal");
            Ajustes.SetActive(false);
            MenúPrincipal.SetActive(true);
            Debug.Log($"El Nivel es {Nivel}");

            if (Nivel >= 1)
            {
                Nivel = 0;
            }
            SceneManager.LoadScene(Nivel);
        }
    }

    public void MenúDePausa()
    {
        if (MenúPausa)
        {
            Debug.Log("El juego fue puesto en pausa");
            Layout.SetActive(false);
            Opciones.SetActive(true);
            Ajustes.SetActive(false);
        }
    }

    public void ReanudarlaPartida()
    {
        if (ReanudarPartida)
        {
            Debug.Log("Se presiono el botón para regresar al Juego");
            MenúPausa.SetActive(false);
            Layout.SetActive(true);
        }
    }

  

}
