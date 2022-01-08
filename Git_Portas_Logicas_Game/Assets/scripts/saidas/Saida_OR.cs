using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script que será usado nos displays de saída

public class Saida_OR : MonoBehaviour
{
    public Sprite saida0, saida1; //sprites importáveis
    public SpriteRenderer spriteRenderer; //renderizador de sprite
    public porta_OR lOr;

    // Start is called before the first frame update
    void Start()
    {
        
        lOr = FindObjectOfType<porta_OR>(); //variável que puxa os valores do script prota_or
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {


        if (lOr.lState == 0)
        {
            spriteRenderer.sprite = saida0;
        }
        else if (lOr.lState == 1)
        {
            spriteRenderer.sprite = saida1;
        }
    }
}
