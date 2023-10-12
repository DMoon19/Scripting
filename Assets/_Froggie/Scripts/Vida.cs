using Microsoft.Unity.VisualStudio.Editor;
using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class Vida : GameManager
{
    Vida(int CurrentLives)
    {
        this.CurrentLives = CurrentLives;
    }

    public new GameObject pipi;

    private void Awake()
    {
        pipi = GetComponent<GameObject>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            gameObject.SetActive(false);
        }
    }
}