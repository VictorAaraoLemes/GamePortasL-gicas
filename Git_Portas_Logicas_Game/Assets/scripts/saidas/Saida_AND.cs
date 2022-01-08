using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script que ser� usado nos displays de sa�da

public class Saida_AND : MonoBehaviour
{
    public Sprite saida0, saida1;
    public SpriteRenderer spriteRenderer;
    public porta_AND lAnd;

    void Start()
    {
        lAnd = FindObjectOfType<porta_AND>(); //vari�vel que puxa os valores do script porta_AND
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(lAnd.lState == 0)
        {
            spriteRenderer.sprite = saida0;
        }
        else if(lAnd.lState == 1)
        {
            spriteRenderer.sprite = saida1;
        }
    }
}
