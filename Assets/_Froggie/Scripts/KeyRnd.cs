using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRnd : MonoBehaviour
{

    public GameObject[] objects;
    void Awake()
    {
        int index=Random.Range(0, objects.Length);
        objects[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
