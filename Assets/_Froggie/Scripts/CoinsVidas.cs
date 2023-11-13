using MoreMountains.CorgiEngine;
using UnityEngine;

public class CoinsVidas : PickableItem
{
        private bool givevida=true;

        [SerializeField]
        protected int monedasPicked2 = 0;

        public int MonedasPicked2
        {
        get{ return monedasPicked2;}
        set{ monedasPicked2=value;}
        }

    void Update()
    {
        if (monedasPicked2 == 10 )
            {
               if (givevida)
            {
               GameManager.Instance.AddLives(1, false);
                givevida=false;
            }
             }
    }
}
