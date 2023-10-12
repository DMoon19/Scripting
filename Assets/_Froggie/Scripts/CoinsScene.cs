using System.Diagnostics;
using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;
using Debug = UnityEngine.Debug;
using UnityEditor.SearchService;

public class CoinsScene : PickableItem
{
 
GameManager Gm;

    [SerializeField] private GameObject Door;
    [SerializeField] protected int monedasPicked = 0;
  
    public GameObject[] objects;

    public int A = 0;

    public int MonedasPicked
    {
        get{ return monedasPicked;}
        set{ monedasPicked=value;}
    }


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

    public void Start()
    {
        UnityEngine.SceneManagement.Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == "MinimalLevel")
        {
            Debug.Log("Nivel:" + sceneName);
        }
        else if (sceneName == "Nivel2")
        {
            Debug.Log("Nivel:" + sceneName);
            monedasPicked -=5;
        }
    }
    private void Update() {

        Gm = FindObjectOfType<GameManager>();

        if (monedasPicked != 0)
        {
            Debug.Log("Monedas:" + monedasPicked);

            if (monedasPicked == 3)
            {
                
                SceneManager.LoadScene("Nivel2");
            }
            if (monedasPicked == -1)
            {
                Door.SetActive(true);
            }
        }
        

        
        
    }


   

}