using UnityEngine;
using System.Collections;

public class Pendulum_Euler : MonoBehaviour {

	Rigidbody rb;
	float fi;
	float t;
	public float l, g;
	float w0, w, psi;

	float func_w(float fi)
	{
		return -(g / l) * Mathf.Sin (fi);
	}

	float func_fi(float w)
	{
		return w;
	}

	float Euler_fi(float w, float t)
	{
		return t * func_fi (w);
	}

	float Euler_w(float fi, float t)
	{
		return t * func_w (fi);
	}

	// Use this for initialization
	void Start () {
		fi = Mathf.PI / 2f;
		l = 10f;
		g = 9.8f;
		rb = GetComponent<Rigidbody> (); // Основной способ получения доступа к rb
		//w0 = Mathf.Sqrt(g / l);
		w0 = 0;
		//rb.position = new Vector3 (l * Mathf.Sin (fi),-l * Mathf.Cos (fi), 0f);
	}
	
	// Update is called once per frame
	void Update () {
		t = Time.deltaTime;
		w = w0 + Euler_w (fi, t);
		psi = fi + Euler_fi (w0, t);
		//psi = fi + w * t;
		//w = w0 - (g / l) * Mathf.Sin (psi) * t;
		rb.position = new Vector3 (l * Mathf.Sin (psi), -l * Mathf.Cos (psi), 0f);
		fi = psi;
		w0 = w;
	}
}
