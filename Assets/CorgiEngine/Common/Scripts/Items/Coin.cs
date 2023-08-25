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

        private int valorObjetivo = 0001500;
        private int contadorActual = 000000;


        public int PointsToAdd = 10;

        void Start()
        {
            contador.text = contadorActual.ToString();
        }
        void Update()
        {
            // Simplemente como ejemplo, incrementamos el contador cada vez que se presiona la tecla "Espacio"
           
               

                // Verificar si hemos alcanzado el valor objetivo
                
            
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
            contador.text = contadorActual.ToString();
            if (contadorActual >= valorObjetivo)
            {
                // Cambiar a la siguiente escena
                SceneManager.LoadScene(escenaSiguiente);
            }
        }
	}
}