using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * lvl: 3 PORTA XOR
A | B | S
0   0   0
0   1   1
1   0   1
1   1   0
*/

public class level_03 : MonoBehaviour
{
    public control ctrl; //referência ao script control
    public Sprite saida0, saida1; //variável para importar os sprites
    public SpriteRenderer spriteRenderer; //variável para renderizar os sprites 1 e 0 na tela
    
    //referência aos scripts dos botões:
    public button bt;
    public button_02 bt2;
    public button_03 bt3;
    public button_04 bt4;

    public int lState = 0; //variável de estado 1 e 0 para as portas lógicas
    void Start()
    {
        ctrl = FindObjectOfType<control>();
        //Definindo uma variável para as referências dos scripts
        bt = FindObjectOfType<button>();
        bt2 = FindObjectOfType<button_02>();
        bt3 = FindObjectOfType<button_03>();
        bt4 = FindObjectOfType<button_04>();

        //Definindo o sprite renderer (coloquei a ação e a imagem no mesmo script)
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }


    void Update()
    {

        //condição para lstate = 0
        if (bt.saida01 == bt2.saida02)
        {
            spriteRenderer.sprite = saida0;
            lState = 0;
        }

        //condição para lstate = 1
        else if (bt.saida01 != bt2.saida02)
        {
            spriteRenderer.sprite = saida1;
            lState = 1;
        }

        //condição para eliminar a colisão de todos os botões uma vez que a fase estiver concluída
        //não queremos que o jogador continue mexendo nos botões depois que a saída dá 1
        if (lState == 1)
        {
            ctrl.currentLevel = 5; //esse valor fica com o tamanho correto para abrir a porta da próxima fase
            Destroy(bt.GetComponent<BoxCollider2D>());
            Destroy(bt2.GetComponent<BoxCollider2D>());
        }
    }
}
