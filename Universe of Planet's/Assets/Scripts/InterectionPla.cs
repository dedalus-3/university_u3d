using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterectionPla : MonoBehaviour
{
    private Rigidbody rb1, rb2;
    public Rigidbody OtherRB1, OtherRB2;
    public Vector3 r1, r2;
    public Vector3 R1, R2;
    public Vector3 V1, V2;
    float g = 6.6740e-2F;
    public float m, M;
    // Start is called before the first frame update
    void Start()
    {
        rb1 = GetComponent<Rigidbody>();
        rb1.position = r1;
        rb1.velocity = V1;

        rb2 = GetComponent<Rigidbody>();
        rb2.position = r2;
        rb2.velocity = V2;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        r1 = rb1.position - OtherRB1.position;
        R1 = rb1.position;
        float l1 = -g * m / Mathf.Pow(r1.magnitude, 2);
        float L1 = -g * M / Mathf.Pow(R1.magnitude, 2);
        rb1.AddForce(l1 * r1 + L1 * R1);

        r2 = rb2.position - OtherRB2.position;
        R2 = rb2.position;
        float l2 = -g * m / Mathf.Pow(r2.magnitude, 2);
        float L2 = -g * M / Mathf.Pow(R2.magnitude, 2);
        rb1.AddForce(l2 * r2 + L2 * R2);
    }
}
