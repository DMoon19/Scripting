using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class Monedas : PickableItem
{
[SerializeField] protected GameObject coins;
[SerializeField] protected GameObject coinsnivel;

    [SerializeField] protected CoinsScene controlCoins;
 [SerializeField] protected CoinsVidas vidasCoins;

    protected override void Pick(GameObject picker)
    {
      

    }
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
     private void OnTriggerEnter2D()
        {

            if (coins.gameObject.CompareTag("Player"))
            {
           vidasCoins.MonedasPicked2++;
                
            }
             else
             {
             controlCoins.MonedasPicked++;
                
             }
        }
//  private void OnTriggerEnter2D(Collider2D coinsnivel)
//         {

//             if (coinsnivel.gameObject.CompareTag("Player"))
//             {
//             controlCoins.MonedasPicked++;
                
//             }
//         }


         
}
