using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public int life = 9;

	// Use this for initialization
	void Start () {
		
	}
    private void OnGUI()
    {
        GUILayout.Label("Vida:  " + life);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
