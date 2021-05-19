using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 0f;

    float horizontalMove = 0f;
    bool jump = false;



    public static bool collectPowerUpSprint = false;

    public static bool collectPowerUpJump = false;

    public static bool collectPowerUpPhase = false;

    // Update is called once per frame
    void Update()
    {

        if (collectPowerUpSprint == false)
        {
            runSpeed = 100f;
        }

        else if (collectPowerUpSprint == true)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                runSpeed = 150f;
            }
            else if (!Input.GetKey(KeyCode.LeftShift))
            {
                runSpeed = 100f;
            }

        }

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));



        if (Input.GetButtonDown("Jump"))
        {
            //FindObjectOfType<AudioManager>().Play("PlayerJump");
            jump = true;
            animator.SetBool("IsJumping", true);
            FindObjectOfType<AudioManager>().Play("Jump");
        }

        if (collectPowerUpPhase == false)
        {
            runSpeed = 100f;
        }

        else if (collectPowerUpPhase == true)
        {
            if ((Input.GetKey(KeyCode.X)) && ((Input.GetKeyDown(KeyCode.RightArrow)) || (Input.GetKeyDown(KeyCode.D))))
            {
                transform.position = new Vector4((transform.position.x + 1f), (transform.position.y), transform.position.z);
            }

            else if ((Input.GetKey(KeyCode.X)) && ((Input.GetKeyDown(KeyCode.LeftArrow)) || (Input.GetKeyDown(KeyCode.A))))
            {
                transform.position = new Vector4((transform.position.x - 1f), (transform.position.y), transform.position.z);
            }
            Debug.Log(transform.position.x);


        }


    }

    public void OnLanding()
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

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("PowerUpSprint"))
        {
            collectPowerUpSprint = true;
            collider.gameObject.SetActive(false);
        }

        if (collider.gameObject.CompareTag("PowerUpPhase"))
        {
            collectPowerUpPhase = true;
            collider.gameObject.SetActive(false);
        }
    }
}