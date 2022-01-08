using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*/

public class level_04 : MonoBehaviour
{
    public control ctrl; //refer�ncia ao script control
    public Sprite saida0, saida1; //vari�vel para importar os sprites
    public SpriteRenderer spriteRenderer; //vari�vel para renderizar os sprites 1 e 0 na tela

    //refer�ncia aos scripts dos bot�es:
    public button bt;
    public button_02 bt2;
    public button_03 bt3;
    public button_04 bt4;

    //vari�veis para facilitar na hora de definir o lstate
    public int porta1 = 0;
    public int porta2 = 0;

    public int lState = 0;
    void Start()
    {
        ctrl = FindObjectOfType<control>();
        //Definindo uma vari�vel para as refer�ncias dos scripts
        bt = FindObjectOfType<button>();
        bt2 = FindObjectOfType<button_02>();
        bt3 = FindObjectOfType<button_03>();
        bt4 = FindObjectOfType<button_04>();

        //Definindo o sprite renderer (coloquei a a��o e a imagem no mesmo script)
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (bt.saida01 == bt2.saida02) porta1 = 0;
        if (bt.saida01 != bt2.saida02) porta1 = 1;

        porta2 = bt3.saida03 * bt4.saida04;

        //condi��o para lstate = 0
        if (porta1 * porta2 == 0)
        {
            spriteRenderer.sprite = saida0;
            lState = 0;
        }

        //condi��o para lstate = 1
        else if (porta1 * porta2 >= 1)
        {
            spriteRenderer.sprite = saida1;
            lState = 1;
        }

        //condi��o para eliminar a colis�o de todos os bot�es uma vez que a fase estiver conclu�da
        //n�o queremos que o jogador continue mexendo nos bot�es depois que a sa�da d� 1
        if (porta1 * porta2 == 1)
        {
            ctrl.currentLevel = 6; //esse valor fica com o tamanho correto para abrir a porta da pr�xima fase
            Destroy(bt.GetComponent<BoxCollider2D>());
            Destroy(bt4.GetComponent<BoxCollider2D>());
        }
    }
}
