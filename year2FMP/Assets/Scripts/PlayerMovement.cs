using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
     
    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;



    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))

        {
            FindObjectOfType<AudioManager>().Play("PlayerJump");
            jump = true;
            animator.SetBool("IsJumping", true);
        }


    }

    public void OnLanding ()
    {
        animator.SetBool("IsJumping", false);

    }

    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("chest"))
        {
            Destroy(other.gameObject);
        }
    }
    */

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
