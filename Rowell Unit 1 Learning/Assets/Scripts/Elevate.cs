using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevate : MonoBehaviour
{
    public float forceMult = 10;
//    private Rigidbody rb;
    private bool active;
    public float elevation;

    // Start is called before the first frame update
    void Start()
    {
        active = false;
    //    rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void Update()
    {
        elevation = rigidbody.velocity.magnitude;
        if (active && elevation < 100)
        {
        transform.position += transform.up * forceMult *Time.deltaTime;
    //        rb.AddForce(transform.up);
    //        rb.AddForce(transform.up * forceMult * Time.deltaTime);
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
