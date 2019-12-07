using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    Rigidbody rb;
    float fi, l, g, t;
    float w0, w, psi, x, y;

	// Use this for initialization
	void Start () {
        fi = Mathf.PI / 2f;
        l = 20f;
        g = 9.8f;
        rb = GetComponent<Rigidbody>(); // Основной способок получения доступа к rb
        w0 = Mathf.Sqrt(g / l);
        rb.position = new Vector3(l * Mathf.Sin(fi), -l * (Mathf.Cos(fi)), 0f);
	}
	
	// Update is called once per frame
	void Update () {
        t = Time.deltaTime;
        psi = fi + w * t;
        w = w0 - (g / l) * Mathf.Sin(psi) * t;
        rb.MovePosition(new Vector3(l * Mathf.Sin(psi), -l * Mathf.Cos(psi), 0f));
        fi = psi;
        w0 = w;
	}
}
