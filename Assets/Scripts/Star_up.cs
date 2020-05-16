using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Star_up : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("to_video",3f);
		
	}
	
	void Update () {
		
	}
    void to_video() {
        SceneManager.LoadScene("Video");
    }
}
