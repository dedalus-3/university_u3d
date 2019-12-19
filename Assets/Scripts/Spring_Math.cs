using UnityEngine;
using System.Collections;

public class Spring_Math : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (0f, 10 * Mathf.Cos (Time.realtimeSinceStartup * Mathf.Sqrt (0.5f) + Mathf.PI / 2f), 0f);
	}
}
