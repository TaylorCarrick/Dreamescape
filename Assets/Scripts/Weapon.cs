using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Destroy enemy if touch by weapon

    }

    void OnCollisionEnter2D(Collision2D col)
    {   //kill enemy if hit
        if (col.collider.tag == "Enemy")
        {
            Destroy(col.collider.gameObject);
        }
        Debug.Log("Player has collided with " + col.collider.name);
    }
}
