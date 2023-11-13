using MoreMountains.CorgiEngine;
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