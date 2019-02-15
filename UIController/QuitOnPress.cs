using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class QuitOnPress : MonoBehaviour {

	
	
	// Update is called once per frame
	public void quit ()
    {
        EditorApplication.isPlaying = false;
	}
}
