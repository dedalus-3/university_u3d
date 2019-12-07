using UnityEngine;
using System.Collections;

public class sphere_move : MonoBehaviour {

    void Update()
    {
        transform.position = new Vector3(0, 10 * Mathf.Cos(Time.realtimeSinceStartup * Mathf.Sqrt(0.5f) + Mathf.PI / 2f), 0);
    }
}
