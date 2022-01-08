using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//BOTÃO N: 1
public class button : MonoBehaviour
{
    public Sprite estado0, estado1;
    public SpriteRenderer spriteRenderer;
    public int saida01;

    private void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    //calculando colisão 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //chave para trocar os valores
        
        if (spriteRenderer.sprite != estado1)
        {
            spriteRenderer.sprite = estado1;
            saida01 = 1;
        }
        else
        {
            spriteRenderer.sprite = estado0;
            saida01 = 0;
        }
        
    }
}
