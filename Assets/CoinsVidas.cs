using System.Diagnostics;
using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;
using Debug = UnityEngine.Debug;
using UnityEditor.SearchService;

public class CoinsVidas : PickableItem
{
    GameManager Gm;
bool givevida=true;
      [SerializeField] protected int monedasPicked2 = 0;
        public int MonedasPicked2
    {
        get{ return monedasPicked2;}
        set{ monedasPicked2=value;}
    }

    void Start()
    {
        Gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (monedasPicked2 == 10 )
            {
               if (givevida)
            {
                Gm.AddLives(1, false);
                givevida=false;
            }
             }
    }
}
