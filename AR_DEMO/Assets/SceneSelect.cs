using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour {

	// Use this for initialization
	public void selectScene () {
        switch (this.gameObject.name){
            case "Playbutton":
                SceneManager.LoadScene("Game");
                break;
            case "Kartebutton":
                SceneManager.LoadScene("Location-basedGame");
                break;

        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
