using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball_controller : MonoBehaviour
{
    //public float speed;
    public float JumpForce;
    private bool IsOnGround;
    private bool falling;

    Rigidbody rigidbody;

    void Start()
    {
        rigidbody = transform.GetComponent<Rigidbody>();
    }

    void Update ()
    {
        movement();
        fall();
    }

    void movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //direction = Vector3.forward;
            rigidbody.AddTorque(Vector3.forward * 25f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //direction = -Vector3.forward;
            rigidbody.AddTorque(-Vector3.forward * 25f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //direction = Vector3.left;
            rigidbody.AddTorque(Vector3.left * 25f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //direction = -Vector3.left;
            rigidbody.AddTorque(-Vector3.left * 25f);
        }

        //rigidbody.AddForce(Input.GetAxis("Horizontal") * speed, 0f, Input.GetAxis("Vertical") * speed);


        if (Physics.Raycast(transform.position, -Vector3.up, 0.801f))
        {
            IsOnGround = true;
        }
        else
        {
            IsOnGround = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && IsOnGround)
        {
            rigidbody.AddForce(0f, JumpForce, 0f);
        }


        //rigidbody.AddTorque(direction * 10f);
    }
    
    void fall()
    {
        if(transform.position.y > -15f)
        {
            falling = false;
        }
        else
        {
            falling = true;
        }

        if(falling)
        {
            string LevelName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(LevelName);
        }
    }
    
}
