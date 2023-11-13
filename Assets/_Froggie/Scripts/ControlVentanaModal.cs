using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;

public class ControlVentanaModal : MonoBehaviour
{
    [SerializeField]
    private GameObject ventana;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AbrirVentana(1.8f));
    }
    public void OnContinuar(){
        CerrarVentana();
        //StartCoroutine(CerrarVentana(2));
    }

    public void CerrarVentana(){
        ventana.SetActive(false);
        GameManager.Instance.Pause(PauseMethods.NoPauseMenu);
    }

    IEnumerator AbrirVentana(float sec){
        yield return new WaitForSecondsRealtime(sec);
        ventana.SetActive(true);
        GameManager.Instance.Pause(PauseMethods.NoPauseMenu);
    }

    IEnumerator CerrarVentana(float sec){
        Debug.Log("Esperar");
        yield return new WaitForSecondsRealtime(sec);
        Debug.Log("Termina espera");
        CerrarVentana();
    }
}
