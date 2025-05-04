using System;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public Rigidbody2D RB;
    
    void Start()
    {
        Destroy(this,2);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Skeleton"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        RB.AddTorque(-2);
    }
}
