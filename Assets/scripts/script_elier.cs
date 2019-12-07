using UnityEngine;
using System.Collections;

public class script_elier : MonoBehaviour {

	void Update () {

        transform.position = new Vector3( 20*Mathf.Cos(Time.realtimeSinceStartup * Mathf.Sqrt(9.8f/2)), -20*Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup * Mathf.Sqrt(9.8f/2))), 0);
	
	}
}
