using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class Monedas : PickableItem
{
[SerializeField] protected GameObject coins;

    [SerializeField] protected CoinsScene controlCoins;

    protected override void Pick(GameObject picker)
    {
          controlCoins.MonedasPicked++;

    }
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }


         
}
