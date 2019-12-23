using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n_Planets : MonoBehaviour
{
    private HashSet<Rigidbody> affectedBodies = new HashSet<Rigidbody>();

    private Rigidbody componentRigidbody;

    private float g = 6.67408e-2F;
    // Start is called before the first frame update
    void Start()
    {
        int vRand = Random.Range(1, 6);
        int massRand = Random.Range(100, 301);
        componentRigidbody = GetComponent<Rigidbody>();
        componentRigidbody.velocity = new Vector3(0f, vRand, 0f);
        componentRigidbody.mass = massRand;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody != null)
        {
            affectedBodies.Add(other.attachedRigidbody);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.attachedRigidbody != null)
        {
            affectedBodies.Remove(other.attachedRigidbody);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (Rigidbody body in affectedBodies)
        {
            Vector3 directionToPlanet = transform.position - body.position;

            float distance = (transform.position - body.position).magnitude;
            float strenght = g * body.mass * componentRigidbody.mass / Mathf.Pow(distance, 2);

            body.AddForce(directionToPlanet * strenght);
        }
    }
}
