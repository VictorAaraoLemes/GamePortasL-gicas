using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueNPC_tutorial : MonoBehaviour
{
    public DESTRUIR alert;
    public Sprite profile;
    public string[] speechTxt;
    public string actorName;
    private int spcblock = 1;

    public LayerMask playerLayer;
    public float radius;

    private dialogueControl dc;
    bool onRadius;

    private void Start()
    {
        alert = FindObjectOfType<DESTRUIR>();
        dc = FindObjectOfType<dialogueControl>();
    }

    private void FixedUpdate()
    {
        Interact();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && onRadius && spcblock == 1)
        {
            dc.Speech(profile, speechTxt, actorName);
            alert.pressionado = true;
            spcblock = 0;
        }
    }

    public void Interact()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radius, playerLayer);
        if(hit != null)
        {
            onRadius = true;
        } else
        {
            onRadius = false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
