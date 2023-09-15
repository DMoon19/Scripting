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

    GameManager Gm;

    // Start is called before the first frame update
    void Start()
    {
        Gm = FindObjectOfType<GameManager>();
        Gm.GainLives(1);
    }
  public GameObject pipi;

        private void OnTriggerEnter2D(Collider2D other)
        {

            if (other.gameObject.CompareTag("Player"))
            {

                Gm.GainLives(1);
                Destroy(gameObject);
				//gameObject.SetActive(false);
            }
        }
}
