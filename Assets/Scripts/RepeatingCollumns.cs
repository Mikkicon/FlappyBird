using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingCollumns : MonoBehaviour {
    private BoxCollider2D groundcollider;
    private float horizontallength;
    // Use this for initialization
    void Start()
    {
        groundcollider = GetComponent<BoxCollider2D>();
        horizontallength = groundcollider.size.x;
    }
    private void reposition()
    {
        Vector2 offset = new Vector2(horizontallength * 17f, 0);
        transform.position = (Vector2)transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        //print("transform.position.x: " + transform.position.x + "\n -horizontallength: " + -horizontallength);
        if (transform.position.x < -horizontallength*2)
        {
            reposition();
        }
    }
}
