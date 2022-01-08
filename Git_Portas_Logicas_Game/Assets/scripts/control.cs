using UnityEngine;
using System.Collections;

//Classe move.
public class control : MonoBehaviour
{
    public float movespeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public int currentLevel = 0;
    Vector2 movement;

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "botao")
        {
            Destroy(col.gameObject);
        }
    }
}