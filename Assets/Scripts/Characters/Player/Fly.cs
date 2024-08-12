using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jumpForce;
    [SerializeField] private float jetpackForce;

    private ForceMode2D forceMode;
    private float totalForce;

    private bool isGrounded = false;
    private bool noInput = false;

    private void Start()
    {
        
    }

    private void Update()
    {
        if(GameManager.Instance.gameOver)
        {
            rb.bodyType = RigidbodyType2D.Static;
        }

        if (GameManager.Instance.isPaused)
        {
            
        }
        else
        {

            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
                {
                    noInput = false;
                    if (isGrounded) // on ground
                    {
                        totalForce = jumpForce;
                        forceMode = ForceMode2D.Impulse;
                        isGrounded = false;
                    }

                    else // mid air
                    {
                        totalForce = jetpackForce;
                        forceMode = ForceMode2D.Force;
                    }
                }
                else
                {
                    totalForce = 0;
                    forceMode = ForceMode2D.Force;
                    noInput = true;
                }
            }
        }
    }

    private void FixedUpdate()
    {
        if(!noInput)
        {
            rb.AddForce(new Vector2(0, totalForce), forceMode);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
