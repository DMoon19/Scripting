using Mono.Cecil.Cil;
using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LevelManager))]
public class SecretRoom : MonoBehaviour
{
    public LevelManager script;
    void Awake()
    {
        script = GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
