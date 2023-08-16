using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittheBall : MonoBehaviour
{
    public float hitForce = 50f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody ballRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if(ballRigidbody != null )
            {
                Vector3 launchDirection = transform.forward;
                ballRigidbody.AddForce(launchDirection * hitForce, ForceMode.Impulse);
            }
        }
    }
}
