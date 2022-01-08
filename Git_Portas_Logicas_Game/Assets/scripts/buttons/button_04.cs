using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Botão n:4
public class button_04 : MonoBehaviour
{
    public Sprite estado0, estado1;
    public SpriteRenderer spriteRenderer;
    public int saida04;

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
            saida04 = 1;
        }
        else
        {
            spriteRenderer.sprite = estado0;
            saida04 = 0;
        }

    }
}
