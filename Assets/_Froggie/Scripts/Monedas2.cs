using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class Monedas2 : PickableItem
{

    [SerializeField] protected CoinsVidas controlCoins;


    protected override void Pick(GameObject picker)
    {
        controlCoins.MonedasPicked2++;
    }
}