using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float jumpForce = 10;
    public bool onGround;
    int JumpsLeft = 2;


    Vector2 respawnPoint;

    public void respawn()
    {
        transform.position = respawnPoint;

    }

    private void Start()
    {
        respawnPoint = transform.position;
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space") && JumpsLeft > 0)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            JumpsLeft--;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        JumpsLeft = 2;
        onGround = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        onGround = false;
    }

    void FixedUpdate()
    {
        transform.Translate(new Vector2(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0));

    }



}   
    

    


