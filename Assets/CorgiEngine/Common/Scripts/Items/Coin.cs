using UnityEngine;
using System.Collections;
using MoreMountains.Tools;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace MoreMountains.CorgiEngine
{
	/// <summary>
	/// Coin manager
	/// </summary>
	[AddComponentMenu("Corgi Engine/Items/Coin")]
	public class Coin : PickableItem
	{
		[Header("Coin")]

		/// The amount of points to add when collected
		[Tooltip("The amount of points to add when collected")]
        public Text contador;
        public string escenaSiguiente; // Nombre de la escena a la que quieres cambiar

        private int valorObjetivo = 1500;
        private int contadorActual = 0;


        public int PointsToAdd = 10;

        void Start()
        {
            contador.text = contadorActual.ToString(); 
        }
      
        /// <summary>
        /// Triggered when something collides with the coin
        /// </summary>
        /// <param name="collider">Other.</param>
        protected override void Pick(GameObject picker) 
		{
			// we send a new points event for the GameManager to catch (and other classes that may listen to it too)
			CorgiEnginePointsEvent.Trigger(PointsMethods.Add, PointsToAdd);
            contadorActual += PointsToAdd;
            print(contadorActual);
            print(PointsToAdd);

            contador.text = contadorActual.ToString();
            if (contadorActual >= valorObjetivo)
            {
                // Cambiar a la siguiente escena
                SceneManager.LoadScene(escenaSiguiente);
            }
        }
	}
}