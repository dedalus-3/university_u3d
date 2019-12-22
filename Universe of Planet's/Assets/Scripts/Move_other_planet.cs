using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_other_planet : MonoBehaviour
{
    public Rigidbody otherPlanet;
    public Vector3 r;
    public Vector3 R;
    public Vector3 V;
    private float g = 6.67408e-2F;
    public float m;
    public float M;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.position = r;
        rb.velocity = V;
    }

    // Update is called once per frame
    void Update()
    {
        r = rb.position - otherPlanet.position;
        R = rb.position;
        float l = - g * m / Mathf.Pow(r.magnitude, 2);
        float L = - g * m / Mathf.Pow(R.magnitude, 2);
        rb.AddForce(l * r + L * R);
    }
}
