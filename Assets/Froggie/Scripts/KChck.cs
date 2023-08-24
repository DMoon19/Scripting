using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Konami))]
public class KChck : MonoBehaviour
{
    private Konami code;
    public Image AvatarHead;
    public Sprite AvatarHead2;
    void Awake()
    {
        code=GetComponent<Konami>();
        
    }

    void Update()
    {
        if (code.success)
        {
            AvatarHead.sprite = AvatarHead2;
          
        }
    }
}
