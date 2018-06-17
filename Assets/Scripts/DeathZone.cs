using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D collider)
    {

        Bird bird = collider.GetComponent<Bird>();
        if (bird != null)
        {
            bird.onDeath();
        }
    }
}
