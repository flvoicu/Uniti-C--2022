using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlller : MonoBehaviour
{

    bool canJump = false;

    void Update(){

        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-5000f * Time.deltaTime,0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(5000f * Time.deltaTime,0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (!Input.GetKey("left") && !Input.GetKey("right"))
        {
             gameObject.GetComponent<Animator>().SetBool("moving", false);
        }

        if(Input.GetKeyDown("up") && canJump)
        {
            canJump = false;
            if(!Input.GetKey("left") && !Input.GetKey("right"))
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,500f));
            }
            else
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,5000f));
            }
           
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "floor")
        {
            canJump = true;
        }
    }

}
