using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Rigidbody rb;

    public float TimeLeft = 3;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 explosion = new Vector3(0f, 0f, 400f);
        rb.AddForce(explosion);
    }

    // Update is called once per frame
    void Update()
    {
        TimeLeft -= Time.deltaTime;
        if ( TimeLeft < 0 )
        {
            Destroy(this.gameObject);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
        }
    }
}
