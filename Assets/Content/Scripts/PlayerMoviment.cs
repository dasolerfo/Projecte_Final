using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public float velocitat = 50f;
    private Rigidbody2D personatge ;

    private Animator animator;
    Vector2 movement;
    // Start is called before the first frame update

    private void Start()
    {
        personatge = this.gameObject.GetComponent<Rigidbody2D>();
        animator = this.gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //if (movement.x != 0 || movement.y != 0) {

        //    if (movement.x == 1) {animator.SetFloat("Ultim", 1); }
        //    if (movement.x == -1) { animator.SetFloat("Ultim", 3); }
        //    if (movement.y == 1) { animator.SetFloat("Ultim", 0); }
        //    if (movement.y == -1) { animator.SetFloat("Ultim", 2); }
           
        //}

        //animator.SetFloat("Horizontal", movement.x);
        //animator.SetFloat("Vertical", movement.y);
        //animator.SetFloat("Speed", movement.sqrMagnitude);


    }

    void FixedUpdate()
    {

        personatge.MovePosition(personatge.position + movement * (int)velocitat );
    }
}
