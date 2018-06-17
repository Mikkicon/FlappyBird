using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    Animator animator;
    Rigidbody2D myBody;
    float zAngleRotation = 0;
    int score = 0;
    public DeathMenu deathMenu;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        myBody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            makeBirdUp();
            animator.SetTrigger("Wave");
            Vector2 vel = myBody.velocity;
            vel.y = 2;
            myBody.velocity = vel;
        }
        else
        {
            if (zAngleRotation >= -90)
            {
                zAngleRotation -= 1.5f;
                transform.eulerAngles = new Vector3(0, 0, zAngleRotation);
            }

        }
    }

    void makeBirdUp()
    {
        while (zAngleRotation < 20)
        {
            zAngleRotation++;
            transform.eulerAngles = new Vector3(0, 0, zAngleRotation);
        }

    }

    public void onDeath()
    {
        //deathMenu.ShowMenu(5, 10);
        Time.timeScale = 0;
    }
}
