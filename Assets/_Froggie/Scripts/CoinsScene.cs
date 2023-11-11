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
 
    [SerializeField] 
    private GameObject door;
    [SerializeField] 
    protected int monedasPicked = 0;
    [SerializeField]
    private GameObject[] objects;
    [SerializeField]
    private int limitador = 0;

    public int MonedasPicked
    {
        get{ return monedasPicked;}
        set{ monedasPicked=value;}
    }


    void Awake()
    {
        List<int> usedIndexes = new List<int>(); // Para evitar duplicados
        for (int i = 0; i < limitador; i++)
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

        if (sceneName == "Level01Normal" || sceneName == "Level01F" || sceneName == "Level01Dif")
        {
            Debug.Log("Nivel:" + sceneName);
        }

        else if (sceneName == "Nivel2" || sceneName == "Nivel2F" || sceneName == "Nivel2Dif")
        {
            Debug.Log("Nivel:" + sceneName);
            monedasPicked -=5;
        }
    }
    public void Update() {

        UnityEngine.SceneManagement.Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;
        if (monedasPicked != 0)
        {
            Debug.Log("Monedas:" + monedasPicked);

            if (monedasPicked == 3 && sceneName == "Level01Normal")
            {
                
                SceneManager.LoadScene("Nivel2");
            }
            if (monedasPicked == 3 && sceneName == "Level01F")
            {

                SceneManager.LoadScene("Nivel2F");
            }
            if (monedasPicked == 3 && sceneName == "Level01Dif")
            {

                SceneManager.LoadScene("Nivel2Dif");
            }
            if (monedasPicked == -1)
            {
                door.SetActive(true);
            }
        }
        

        
        
    }


   

}