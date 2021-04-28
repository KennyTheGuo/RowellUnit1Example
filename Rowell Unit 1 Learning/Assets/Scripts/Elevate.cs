using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevate : MonoBehaviour
{
    public float forceMult = 10;
    private Rigidbody rb;
    private bool active;
    public float elevation;
    public float elevationLimit;
//    public float speedMod;

    // Start is called before the first frame update
    void Start()
    {
        active = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void Update()
    {
        elevation = GetComponent<Rigidbody>().velocity.magnitude;
        if (active && elevation < elevationLimit)
        {
    //    transform.position += transform.up * forceMult *Time.deltaTime;
            rb.AddForce(transform.up);
            rb.AddForce(transform.up * forceMult * Time.deltaTime);
        }

    //    if (elevation > elevationLimit)
        {
    //        active = false;
        }

    //    if (!active && elevation > 0)
        {
    //    transform.position += -transform.up * forceMult *Time.deltaTime;
    //        rb.AddForce(-transform.up);
    //        rb.AddForce(transform.up * forceMult * Time.deltaTime * speedMod);
    //        active = true;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            active = true;
        }
    }
}
