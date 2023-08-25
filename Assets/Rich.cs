using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rich : Coin
{
    public Text contador;
    public string escenaSiguiente; // Nombre de la escena a la que quieres cambiar

    private int valorObjetivo = 1500;
    private int contadorActual = 0;

    // Start is called before the first frame update
    void Start()
    {
        contador.text = contadorActual.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // Simplemente como ejemplo, incrementamos el contador cada vez que se presiona la tecla "Espacio"
        if (Input.GetKeyDown(KeyCode.Space))
        {
            contadorActual++;
            contador.text = contadorActual.ToString();

            // Verificar si hemos alcanzado el valor objetivo
            if (contadorActual >= valorObjetivo)
            {
                // Cambiar a la siguiente escena
                SceneManager.LoadScene(escenaSiguiente);
            }
        }
    }
}