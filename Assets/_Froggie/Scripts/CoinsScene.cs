using System.Diagnostics;
using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;
public class CoinsScene : PickableItem
{
 
GameManager Gm;



    public GameObject[] objects;

    public int A = 0;

    void Awake()
    {
        List<int> usedIndexes = new List<int>(); // Para evitar duplicados
        for (int i = 0; i < A; i++)
        {
            int index;
            do
            {
                index = Random.Range(0, objects.Length);
            } while (usedIndexes.Contains(index));

            usedIndexes.Add(index);
            objects[index].SetActive(true);
        }
    }
    private void Update() {
        Gm = FindObjectOfType<GameManager>();

        if(Gm.Points >=001500 ){
        
               SceneManager.LoadScene("Nivel2");
        }
        
    }


   

}