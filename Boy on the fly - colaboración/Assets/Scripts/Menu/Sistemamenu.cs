using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sistemamenu : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }

    public void jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo del juego...");
    }
}
