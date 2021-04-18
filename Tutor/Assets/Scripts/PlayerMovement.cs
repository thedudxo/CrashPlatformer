using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed = 10;
    [SerializeField] float jump = 10;
    [SerializeField] bool hasJumped = false;
    [SerializeField] int collidersTouching = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 force = new Vector3();

        float velX = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector3(velX, rb.velocity.y, 0);


        Debug.DrawRay(transform.position, -transform.up * 1.1f, Color.red);

        if (hasJumped)
        {
            if (Physics.Raycast(transform.position, -transform.up, 1.1f))
            {
                hasJumped = false;
            }
        }

        else
        {
            bool shouldJump = Input.GetKeyDown(KeyCode.UpArrow) && collidersTouching > 0;
            if (shouldJump)
            {
                rb.velocity = new Vector3(rb.velocity.x, jump, 0);
                hasJumped = true;
            }
        }

        rb.AddForce(force * 100 * Time.deltaTime);
    }


    private void OnCollisionEnter(Collision collision)
    {
        collidersTouching++;
    }

    private void OnCollisionExit(Collision collision)
    {
        collidersTouching--;
    }
}
