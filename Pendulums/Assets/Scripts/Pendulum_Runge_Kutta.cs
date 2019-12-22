using UnityEngine;
using System.Collections;

public class Pendulum_Runge_Kutta : MonoBehaviour {

	Rigidbody rb;
	public float g = 9.8f;
	public float l = 10f;
	float fi, psi, w, w0;
	float t;

	float func_w(float fi)
	{
		return -(g / l) * Mathf.Sin (fi);
	}

	float func_fi(float w)
	{
		return w;
	}

	float Runge_Kutta_fi(float w, float t)
	{
		float k1 = 0, k2 = 0, k3 = 0, k4 = 0;
		k1 = t * func_fi (w);
		k2 = t * func_fi (w + (1f / 2) * k1);
		k3 = t * func_fi (w + (1f / 2) * k2);
		k4 = t * func_fi (w + k3);
		return (1f / 6) * (k1 + 2 * k2 + 2 * k3 + k4);
	}

	float Runge_Kutta_w(float fi, float t)
	{
		float k1 = 0, k2 = 0, k3 = 0, k4 = 0;
		k1 = t * func_w (fi);
		k2 = t * func_w (fi + (1f / 2) * k1);
		k3 = t * func_w (fi + (1f / 2) * k2);
		k4 = t * func_w (fi + k3);
		return (1f / 6) * (k1 + 2 * k2 + 2 * k3 + k4);
	}
	// Use this for initialization
	void Start () {
		fi = Mathf.PI / 2f;
		rb = GetComponent<Rigidbody> ();
		w0 = 0;

	}
	
	// Update is called once per frame
	void Update () {
		t = Time.deltaTime;
		w = w0 + Runge_Kutta_w (fi, t);
		psi = fi + Runge_Kutta_fi (w0, t);
		rb.position = new Vector3 (l * Mathf.Sin (psi), -l * Mathf.Cos (psi), 0f);
		fi = psi;
		w0 = w;
	}
}
