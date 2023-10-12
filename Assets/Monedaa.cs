using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
 
public class Monedaa : MonoBehaviour, MMEventListener<PickableItemEvent>
{
 private int contador_monedas;
 
 void OnEnable()
 {
 this.MMEventStartListening<PickableItemEvent>();
 }
 void OnDisable()
 {
 this.MMEventStopListening<PickableItemEvent>();
 }
 
 public virtual void OnMMEvent(PickableItemEvent item)
 {
 if(++contador_monedas == 10)
 {
 GameManager.Instance.GainLives(1);
 contador_monedas = 0;
 }
 }
 
}