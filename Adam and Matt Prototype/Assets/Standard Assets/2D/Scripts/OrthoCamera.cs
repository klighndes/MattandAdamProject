using UnityEngine;
using System.Collections;

public class OrthoCamera : MonoBehaviour {

	public int scale = 1;

	// Use this for initialization
	void Start () {
		GetComponent<Camera>().orthographicSize = (Screen.height / 1f / 2.0f) / (float)scale;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Camera>().orthographicSize = (Screen.height / 1f / 2.0f) / (float)scale;
	}
}
