using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class level_05 : MonoBehaviour
{
    public control ctrl; //refer�ncia ao script control
    public Sprite saida0, saida1; //vari�vel para importar os sprites
    public SpriteRenderer spriteRenderer; //vari�vel para renderizar os sprites 1 e 0 na tela

    //refer�ncia aos scripts dos bot�es:
    public button bt;
    public button_02 bt2;
    public button_03 bt3;
    public button_04 bt4;

    public int lState = 0; //vari�vel de estado 1 e 0 para as portas l�gicas;
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
        //condi��o para o lstate dar 0
        if (bt.saida01 * bt2.saida02 * bt3.saida03 * bt4.saida04 < 1)
        {
            spriteRenderer.sprite = saida0;
            lState = 0;
        }

        //condi��o para o lstate dar 1
        else if (bt.saida01 * bt2.saida02 * bt3.saida03 * bt4.saida04 >= 1)
        {
            spriteRenderer.sprite = saida1;
            lState = 1;
        }

        //condi��o para eliminar a colis�o de todos os bot�es uma vez que a fase estiver conclu�da
        //n�o queremos que o jogador continue mexendo nos bot�es depois que a sa�da d� 1
        if (lState == 1)
        {
            ctrl.currentLevel = 7; //esse valor fica com o tamanho correto para abrir a porta da pr�xima fase
            Destroy(bt.GetComponent<BoxCollider2D>());
            Destroy(bt2.GetComponent<BoxCollider2D>());
            Destroy(bt3.GetComponent<BoxCollider2D>());
            Destroy(bt4.GetComponent<BoxCollider2D>());
        }
    }
}
