using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextLevel : MonoBehaviour {
    private void Awake()
    {
    
    }

    void Start () {
        
    }
	
	void Update () {
		
	}

    private void OnMouseUpAsButton() {
        SceneManager.LoadScene("ItemSceneAfterCases");
    }
}
