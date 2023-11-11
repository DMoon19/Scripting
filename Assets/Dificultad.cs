using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Dificultad : MonoBehaviour
{

    [SerializeField]
    GameObject panel;
    [SerializeField]
    GameObject fade;
    // Start is called before the first frame update

    public void ActivarPanel()
    {
        panel.SetActive(true);
        fade.SetActive(true);

    }
}
