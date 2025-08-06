using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class Bola : MonoBehaviour
{
    public bool isGameStarted = false;
    //public bool MainScene = false;
    [SerializeField] public float velocidadBola = 10f;
    AdministradordeMenús Niveles;

    void Start()
    {
        Vector2 posicionInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        posicionInicial.y += 2;
        this.transform.position = posicionInicial;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (!isGameStarted)
            {
                isGameStarted = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().linearVelocity = velocidadBola * Vector2.up;
            }
        }
    }   
}
