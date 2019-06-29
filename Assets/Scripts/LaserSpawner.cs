using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawner : MonoBehaviour
{
    public GameObject laser;

    private float nextActionTime = 0.0f;
    public float period = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            GameObject laserClone = Instantiate(laser, transform);

            laserClone.transform.Rotate(0, 0, Random.Range(0, 360));
        }
    }
}
