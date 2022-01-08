using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//PORTA OR
// A | B | S 
// 0 | 0 | 0
// 0 | 1 | 1
// 1 | 0 | 1
// 1 | 1 | 1

public class porta_OR : MonoBehaviour
{
    public control ctrl;
    public button bt;
    public button_02 bt2;
    public button_03 bt3;
    public button_04 bt4;
    public int lState = 0;
    void Start()
    {
        ctrl = FindObjectOfType<control>();
        //Definindo uma variável para as referências dos scripts
        bt = FindObjectOfType<button>();
        bt2 = FindObjectOfType<button_02>();
        bt3 = FindObjectOfType<button_03>();
        bt4 = FindObjectOfType<button_04>();
    }


    void Update()
    {
        

        if ((bt3.saida03) +(bt4.saida04) < 1)
        {
            lState = 0;
        }
        else if ((bt3.saida03) + (bt4.saida04) >= 1)
        {
            lState = 1;
        }

        if (lState == 1)
        {
            ctrl.currentLevel = 2;
            Destroy(bt3.GetComponent<BoxCollider2D>());
            Destroy(bt4.GetComponent<BoxCollider2D>());
        }
    }
}
