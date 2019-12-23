using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject nPlanet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
       {
           int xAxis = Random.Range(-5, 10);
           int yAxis = Random.Range(-5, 10);
           int zAxis = Random.Range(-5, 10);
           Instantiate(nPlanet, new Vector3(xAxis, yAxis, zAxis), Quaternion.identity);
       } 
    }
}
