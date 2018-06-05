using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
    public int health = 100;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(health == 0)
        {
            //gameover screen
            //SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
            SceneManager.LoadScene("GameOver");
        }
	}
}
