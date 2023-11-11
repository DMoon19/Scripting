using UnityEngine;
using System.Collections;
using MoreMountains.Tools;
using System.Collections.Generic;
using MoreMountains.InventoryEngine;
using MoreMountains.Feedbacks;
using System.Diagnostics;
using MoreMountains.CorgiEngine;

public class Pipi : MonoBehaviour
{
    [SerializeField]
    private GameObject pipi;

        private void OnTriggerEnter2D(Collider2D other)
        {

            if (other.gameObject.CompareTag("Player"))
            {

                GameManager.Instance.GainLives(1);
                Destroy(gameObject);
            }
        }
}
