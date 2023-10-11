using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using Debug = UnityEngine.Debug;
using MoreMountains.CorgiEngine;

public class OneLiveCoins : PickableItem 
{
  [SerializeField] private GameObject[] vidasExtra;
 [SerializeField] private GameObject Aca;

  public int contadorM;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
    if(other.gameObject.CompareTag("Monedasvida"))
        {
        contadorM++;
        Debug.Log(contadorM);
       if(contadorM == 10)
         {
            int index = 0;
            vidasExtra[index].SetActive(true);
         }
            if(contadorM == 20)
         {
            int index = 1;
            vidasExtra[index].SetActive(true);
         }
        }

    }
}
