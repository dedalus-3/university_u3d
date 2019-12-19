using UnityEngine;
using System.Collections;

public class Pendulum_Math : MonoBehaviour {

	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (10f * Mathf.Sin (Time.realtimeSinceStartup * Mathf.Sqrt (9.8f / 10)), -10f * Mathf.Abs(Mathf.Cos (Time.realtimeSinceStartup * Mathf.Sqrt (9.8f / 10))), 0f);
	}
}
